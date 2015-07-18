using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasylEncryptionStandard;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using System.IO;
using Org.BouncyCastle.OpenSsl;
using System.Numerics;
using Org.BouncyCastle.Crypto.Parameters;
using System.Threading;

namespace BasylEncryptionStandard.RSA
{
    public class BasylRSAUtilities
    {
        
        //OLD CODE//
        /// <summary>
        /// This generates an RSA Key Pair using a hijacked BouncyCastle approach. 
        /// </summary>
        /// <param name="keyGen"></param>
        /// <param name="keySize"></param>
        /// <returns></returns>
        public static AsymmetricCipherKeyPair GenerateKeyPair2(IBasylKeyGenerator keyGen, int keySize)
        {
            RsaKeyPairGenerator rsaGenerator = new RsaKeyPairGenerator();
            rsaGenerator.Init(new KeyGenerationParameters(new BasylSecureRandom(keyGen), keySize));
            AsymmetricCipherKeyPair keys = rsaGenerator.GenerateKeyPair();
            return keys;
        }
        //OLD CODE END//
        


        private void GenerateP()
        {
            p = GetRandomLargePrime(gen, gSize / 2 + 8);
        }

        private void GenerateQ()
        {
            q = GetRandomLargePrime(gen, gSize / 2 + 8);
        }


        //Yeah, not entirely thread safe atm.
        private BigInteger p, q;
        private int gSize;
        private IBasylKeyGenerator gen;

        /// <summary>
        /// Generates a key pair using a portable BES approach. 
        /// </summary>
        /// <param name="keyGen"></param>
        /// <param name="keySize"></param>
        /// <returns></returns>
        public AsymmetricCipherKeyPair GenerateKeyPair(IBasylKeyGenerator keyGen, int keySize)
        {
            gSize = keySize;
            gen = keyGen;
            
            Thread thread = new Thread(new ThreadStart(GenerateP)), 
            thread2 = new Thread(new ThreadStart(GenerateQ));
            thread.Start(); 
            thread2.Start();
           

            thread.Join();
            thread2.Join();

            var n = p * q;
            var e = 65537;
            var phi = (p - 1) * (q - 1);


            var d = (new Org.BouncyCastle.Math.BigInteger(e.ToString())).ModInverse(phi.Convert());

            var dP = d.Remainder((p - 1).Convert());
            var dQ = d.Remainder((q - 1).Convert());
            var qInv = q.Convert().ModInverse(p.Convert());

        

            return new AsymmetricCipherKeyPair(
                new RsaKeyParameters(false, n.Convert(), new Org.BouncyCastle.Math.BigInteger(e.ToString())),
                new RsaPrivateCrtKeyParameters(n.Convert(), new Org.BouncyCastle.Math.BigInteger(e.ToString()), d, p.Convert(), q.Convert(), dP, dQ, qInv));
        }
      

        /// <summary>
        /// Generates a random large prime near the given bit size.
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        private static BigInteger GetRandomLargePrime(IBasylKeyGenerator generator, int size)
        {
           //fills an array with random bytes. This is used for the prime search.
            byte[] vals = new byte[(int)Math.Ceiling(size / 8.0f)];

            lock (generator)
            {
                for (int i = 0; i < 20; i++)
                {
                    generator.FillBytes(vals);
                }

                for (int k = 0; k < 2; k++)
                    for (int i = 0; i < vals.Length; i++)
                    {
                        for (int n = 0; n < 3; n++)
                            generator.GetRandomByte();
                        generator.EncryptByte(ref vals[i]);
                    }
            }

            //searches for the prime number, decreases until it finds one that tests to be prime. 
            BigInteger gco = new BigInteger(vals);
            if(gco < 0)
            {
                gco *= -1;
            }

            if (gco.IsEven)
            {
                gco -= 1;
            }

            var bouncyCastleBig = gco.Convert();
            var amt = new BigInteger(2).Convert();
      
            while (!bouncyCastleBig.IsProbablePrime(1))
            {
                bouncyCastleBig = bouncyCastleBig.Subtract(amt);
                gco -= 2;
            }
            //Bouncy castles isProbablePrime method is severely optimized compared to a naive approach. 

            return gco;
          
        }


        /// <summary>
        /// Gets the PEM for the Public Key from the Asymmetric Key Pair.
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public static String GetPublicKey(AsymmetricCipherKeyPair keys)
        {

            TextWriter textWriter = new StringWriter();
            PemWriter pemWriter = new PemWriter(textWriter);
            pemWriter.WriteObject(keys.Public);
            pemWriter.Writer.Flush();

            return textWriter.ToString();
        }

        /// <summary>
        /// Gets the PEM for the Private Key from the Asymmetric Key Pair.
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public static String GetPrivateKey(AsymmetricCipherKeyPair keys)
        {
            TextWriter textWriter = new StringWriter();
            PemWriter pemWriter = new PemWriter(textWriter);
            pemWriter.WriteObject(keys.Private);
            pemWriter.Writer.Flush();
            return textWriter.ToString();
        }

        /// <summary>
        /// Reads a Private Key. Returns the Full Key Pair.
        /// </summary>
        /// <param name="key">Key to be parsed.</param>
        /// <returns></returns>
        public static AsymmetricCipherKeyPair ReadPrivateKey(String key)
        {
            PemReader pemReader = new PemReader(new StringReader(key));
            object pemReadObject = pemReader.ReadObject();

            if (pemReadObject is AsymmetricCipherKeyPair) //Checks if Private Key
            {
                return ((AsymmetricCipherKeyPair)pemReadObject);
            }

            return null;
        }

        /// <summary>
        /// Reads a public or private key and exports it as an asymmetric key parameter.
        /// Will attempt to return null if invalid string passed in. Error may be thrown.
        /// </summary>
        /// <param name="key">Key to be parsed.</param>
        /// <returns></returns>
        public static AsymmetricKeyParameter ReadKey(String key)
        {
            AsymmetricKeyParameter keyParameter = null;
            PemReader pemReader = new PemReader(new StringReader(key)); 
            object pemReadObject = pemReader.ReadObject();
        

            if(pemReadObject is AsymmetricCipherKeyPair) //Checks if Private Key
            {
                keyParameter = ((AsymmetricCipherKeyPair)pemReadObject).Private; //Extracts only the private key to be returned.
            }
            else if(pemReadObject is AsymmetricKeyParameter) //Checks if Public Key
            {
                keyParameter = (AsymmetricKeyParameter)pemReadObject;
            }

            return keyParameter;
        }


    }
}
