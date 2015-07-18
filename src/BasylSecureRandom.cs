using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BasylEncryptionStandard;

namespace BasylEncryptionStandard.RSA
{
    /// <summary>
    /// A Hijacked Secure Random.
    /// This allows me to use BES to create RSA keys.
    /// </summary>
    class BasylSecureRandom : SecureRandom
    {

        private IBasylKeyGenerator keyGen;
        public BasylSecureRandom(IBasylKeyGenerator keyGen)
        {
            this.keyGen = keyGen;
        }

        public IBasylKeyGenerator GetKeyGenerator()
        {
            return keyGen;
        }

        protected override double Sample()
        {
            return NextDouble();
        }

        public override void NextBytes(byte[] buffer, int start, int length)
        {
            keyGen.FillBytes(buffer, start, length);
        }

        public override int NextInt()
        {
            byte[] num = new byte[4];

            keyGen.FillBytes(num, 0, 4);
            int z = BitConverter.ToInt32(num, 0);
            return Math.Abs(z);
        }

        public override int Next(int maxValue)
        {
            byte[] num = new byte[8];
            keyGen.FillBytes(num, 0, 8);
            long z = BitConverter.ToInt64(num, 0);
            return Math.Abs((int)(z % maxValue));
        }

        public override double NextDouble()
        {
            byte[] num = new byte[8];
            keyGen.FillBytes(num, 0, 8);
            double z = BitConverter.ToDouble(num, 0);
            return Math.Abs(z - (long)z);
        }

        public override void NextBytes(byte[] buffer)
        {
            keyGen.FillBytes(buffer, 0, buffer.Length);
        }

        public override long NextLong()
        {
            byte[] num = new byte[8];
            keyGen.FillBytes(num, 0, 8);
            long z = BitConverter.ToInt64(num, 0);
            return z;
        }

        public override int Next(int minValue, int maxValue)
        {
            byte[] num = new byte[8];
            keyGen.FillBytes(num, 0, 8);
            long z = BitConverter.ToInt64(num, 0);
            return (int)(z % (maxValue-minValue)) + minValue;
        }

        public override int Next()
        {
            byte[] num = new byte[4];

            keyGen.FillBytes(num, 0, 4);
            int z = BitConverter.ToInt32(num, 0);
            return Math.Abs(z);
        }

        public override byte[] GenerateSeed(int length)
        {
            byte[] arr = new byte[length];
            keyGen.FillBytes(arr, 0, length);
            return arr;
        }


    }
}
