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
                RSA Rsa = new RSA();
                base.Component.Text = Rsa.encode(base.Component.tp.Text);
                //base.Save();

                //if (String.IsNullOrEmpty(base.Component.tp.Text))
                //{
                //    throw new ArgumentNullException
                //           ("The string which needs to be encrypted can not be null.");
                //}
                //DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                //MemoryStream memoryStream = new MemoryStream();
                //CryptoStream cryptoStream = new CryptoStream(memoryStream,
                //    cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
                //StreamWriter writer = new StreamWriter(cryptoStream);
                //writer.Write(base.Component.tp.Text);
                //writer.Flush();
                //cryptoStream.FlushFinalBlock();
                //writer.Flush();
                
                //StreamReader s =new StreamReader(cryptoStream);
                //base.Component.Text =s.ReadToEnd();
                //base.Component.Text =Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
            }

            public string Decrypt() // расшифровка сообщения
            {
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                MemoryStream memoryStream = new MemoryStream
                        (Convert.FromBase64String(base.Component.Text));
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                    cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cryptoStream);
                return reader.ReadToEnd();
            }

            public override void SetData()
            {
            }
    }
}
