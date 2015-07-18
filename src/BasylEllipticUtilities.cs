using BasylEncryptionStandard;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasylEncryptionStandard.RSA
{
    class BasylEllipticUtilities
    {
     
        /// <summary>
        /// Gets the curve from the name passed in, assuming it exists.
        /// </summary>
        /// <param name="curveName"></param>
        /// <returns>The curve requested</returns>
        public static X9ECParameters GetCurveFromName(string curveName)
        {
            Org.BouncyCastle.Asn1.X9.X9ECParameters ecp = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByName(curveName);

            if (ecp == null)
            {
                ecp = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetByName(curveName);
            }

            if (ecp == null)
            {
                ecp = Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetByName(curveName);
            }

            if (ecp == null)
            {
                ecp = Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetByName(curveName);
            }


            return ecp;
        }


        /// <summary>
        /// This generates an elliptic curve key pair. Uses BouncyCastle library for generation.
        /// Hijacked by the BES Random Generator.
        /// </summary>
        /// <param name="keyGen"></param>
        /// <param name="keySize"></param>
        /// <returns></returns>
        public static AsymmetricCipherKeyPair GenerateKeyPair(IBasylKeyGenerator keyGen, string curveName)
        {
            var ecGenerator = new ECKeyPairGenerator("ECDH");

            var ecp = GetCurveFromName(curveName);

            ECDomainParameters ecSpec = new ECDomainParameters(ecp.Curve, ecp.G, ecp.N, ecp.H, ecp.GetSeed());
            ECKeyGenerationParameters ecgp = new ECKeyGenerationParameters(ecSpec, new BasylSecureRandom(keyGen));

            ecGenerator.Init(ecgp);

            AsymmetricCipherKeyPair keys = ecGenerator.GenerateKeyPair();
           
            return keys;
        }
    }
}
