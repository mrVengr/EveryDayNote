namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using System.Windows.Controls;
    using System.Windows;
    using System.Windows.Media;
    using System.IO;

    public class TextEncrypt : TextDecorator
    {
        public override void Create()
        {
        }

        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        public override void Encrypt()
            {
                //RSA Rsa = new RSA();
                //base.Component.Text = Rsa.encode(base.Component.tp.Text);

                try
                {
                    UnicodeEncoding ByteConverter = new UnicodeEncoding();
                    byte[] encryptedData;
                    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                    {
                        RSA.ImportParameters(RSA.ExportParameters(false));
  
                        
                        byte[] Data = ByteConverter.GetBytes(base.Component.tp.Text);
                        encryptedData = RSA.Encrypt(Data , false);
                    }
                    base.Component.Text = ByteConverter.GetString(encryptedData);
                }
                //Catch and display a CryptographicException  
                //to the console.
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                    base.Component.Text = base.Component.tp.Text;
                }
               
            }

            public string Decrypt() // расшифровка сообщения
            {
                try
                {
                    UnicodeEncoding ByteConverter = new UnicodeEncoding();
                    byte[] decryptedData;
                    //Create a new instance of RSACryptoServiceProvider.
                    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                    {
                        RSA.ImportParameters(RSA.ExportParameters(true));

                        byte[] Data = ByteConverter.GetBytes(base.Component.Text);
                        decryptedData = RSA.Decrypt(Data, false);
                    }
                    return ByteConverter.GetString(decryptedData);
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.ToString());

                    return null;
                }
            }

            public override void SetData()
            {
            }
    }
}
