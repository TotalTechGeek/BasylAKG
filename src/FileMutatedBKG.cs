using BasylEncryptionStandard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasylEncryptionStandard.RSA
{
    /// <summary>
    /// The idea behind this extension is that it will consume a file stream and
    /// use it as a seed. The internal cipher will make it impossible to predict.
    /// 
    /// </summary>
    class FileMutatedBKG : IBasylKeyGenerator
    {

        private BESCipher cipher;
        private BasylKeyGenerator generator;
        private PseudoRandomGenerator prg;

        public FileMutatedBKG(BasylKeyGenerator keyGen, Stream stream)
        {
            this.generator = keyGen;
            this.cipher = new BESCipher(keyGen);


            byte[] extra = new byte[100];
            byte[] extra2 = new byte[64];

            int amount = 65536;
            while (amount != 0)
            {
                byte[] buffer = new byte[amount];
                while (stream.Position + amount < stream.Length)
                {
                    stream.Read(buffer, 0, amount);
                    cipher.EncryptRight(ref buffer);
                    cipher.EncryptLeft(ref extra);
                    cipher.EncryptRight(ref extra2);
                }
                cipher.EncryptLeft(ref extra2);
                cipher.Shuffle(2);
                amount /= 2;
            }

            prg = new PseudoRandomGenerator(256 * 256, "MutatedBKG", 500);
            prg.ExpandKey(1);
            prg.SetSeedKey(extra);
            prg.SetSHA(extra2);
            prg.Recycle();
        

            stream.Close();
          
        }

        public override void Drop()
        {
            generator.Drop();
            
        }

        public override void EncryptByte(ref byte byt)
        {
            byt ^= GetRandomByte();
        }

        public override byte GetRandomByte()
        {
            byte r = generator.GetRandomByte();
            r ^= prg.GetRandomByte();
            cipher.EncryptLeft(ref r); 
            return r;
        }
    }
}
