using Jose;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Servizio_C020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Risultato_TextChanged(object sender, EventArgs e)
        {
        }

        private void Voucher_Click(object sender, EventArgs e)
        {
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                string clientAssertion = JWTAsserzione();
                Risultato.Text = clientAssertion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }

        private string JWTAsserzione()
        {
            string privateKeyPath = "C:\\Keys\\private-key-anpr.pem";

            var privateKey = File.ReadAllText(privateKeyPath);

            RSA rsaPrivateKey = LoadRsaPrivateKeyFromPEM(privateKey);
            var clientId = "43cd0ac6-fbc0-4c9b-8571";
            var payload = new
            {
                iss = clientId,
                sub = clientId,
                aud = "auth.interop.pagopa.it/client-assertion",
                purposeId = "040a1a59-2029",
                jti = Guid.NewGuid().ToString(),
                iat = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                exp = DateTimeOffset.UtcNow.AddDays(10).ToUnixTimeSeconds()
            };

            var headers = new Dictionary<string, object>
        {
            { "kid", "KmQf57I2M3FadyXwU__dD0KjaXKPCRd5oXYVYNQWnXE" },
            { "alg", "RS256" },
            { "typ", "JWT" }
        };

            string token = JWT.Encode(payload, rsaPrivateKey, JwsAlgorithm.RS256, headers);

            // Visualizza il token solo a scopo di debug
            MessageBox.Show("Token JWT firmato:\n" + token);

            return token;
        }

        private RSA LoadRsaPrivateKeyFromPEM(string privateKey)
        {
            using (var stringReader = new StringReader(privateKey))
            {
                var pemReader = new PemReader(stringReader);
                var keyPair = (AsymmetricCipherKeyPair)pemReader.ReadObject();

                var rsaParameters = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)keyPair.Private);
                var rsa = RSA.Create();
                rsa.ImportParameters(rsaParameters);

                return rsa;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
