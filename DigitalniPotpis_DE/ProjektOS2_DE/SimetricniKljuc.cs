using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniPotpis
{
    class SimetricniKljuc
    {
        public byte[] IV { get; set; }
        public byte[] kljuc { get; set; }
        private string kriptiraniTekst { get; set; }
        public byte [] kriptiraniBitovi { get; set; }

        
        public byte[] Kriptiraj(string obicanTekst)
        {
            RijndaelManaged objektKripto = null;
            MemoryStream memStream = null;
            ICryptoTransform enkriptor = null;
            CryptoStream enkriptoStream = null;

            UTF8Encoding Byte_Transform = new UTF8Encoding();

            byte [] obicniBitovi = Byte_Transform.GetBytes(obicanTekst);

            try
            {
                objektKripto = new RijndaelManaged();
                memStream = new MemoryStream();

                enkriptor = objektKripto.CreateEncryptor(kljuc,IV);
                enkriptoStream = new CryptoStream(memStream,enkriptor,CryptoStreamMode.Write);
                enkriptoStream.Write(obicniBitovi,0,obicniBitovi.Length); 
            }
            finally
            {
                if (objektKripto != null)
                    objektKripto.Clear();
                enkriptoStream.Close();
            }
            return memStream.ToArray();
        }


        public string Dekriptiraj(byte [] kriptiraniTekst)
        {
            RijndaelManaged objektKripto = null;
            MemoryStream memStream = null;
            ICryptoTransform dekriptor = null;
            CryptoStream kriptoStream = null;
            StreamReader streamCitac = null;

            UTF8Encoding Byte_Transform = new UTF8Encoding();

            string obicanTekst = "";

            try
            {
                objektKripto = new RijndaelManaged();
                memStream = new MemoryStream(kriptiraniTekst);

                dekriptor = objektKripto.CreateDecryptor(kljuc, IV);
                kriptoStream = new CryptoStream(memStream, dekriptor, CryptoStreamMode.Read);
                streamCitac = new StreamReader(kriptoStream);
                obicanTekst = streamCitac.ReadToEnd();
            }
            finally
            {
                if (objektKripto != null)
                    objektKripto.Clear();
                memStream.Flush();
                memStream.Close();
            }
            return obicanTekst;
        }

        public void SpremiUDatoteku(string putanja,byte [] kriptiraniTekst)
        {
            if (!File.Exists(putanja))
            {
                FileInfo file = new FileInfo(putanja);
                file.Directory.Create();
                File.WriteAllText(file.FullName, Convert.ToBase64String(kriptiraniTekst));
            }
            else if (File.Exists(putanja))
            {
                FileInfo file = new FileInfo(putanja);
                File.WriteAllText(file.FullName, Convert.ToBase64String(kriptiraniTekst));
            }
        }
    }
}
