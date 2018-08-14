using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniPotpis
{
    class DigitalniPotpis
    {
        public string ucitaniJavniKljuc { get; set; }
        public byte[] potpis { get; set; }
        public byte[] IzracunajSazetak(string ucitaniTekst) {
            byte[] obicniTekst = Encoding.UTF8.GetBytes(ucitaniTekst);

            SHA1 objektSHA = new SHA1CryptoServiceProvider();
            string putanjaSazetak = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Potpis\Sazetak.txt";
            string sazetak= Convert.ToBase64String(objektSHA.ComputeHash(obicniTekst));
            SpremiUDatoteku(putanjaSazetak, sazetak);

            return objektSHA.ComputeHash(obicniTekst);
        }
        public byte[] Potpis(byte[] sazetak) {
            RSACryptoServiceProvider objektRSA = new RSACryptoServiceProvider();

            string putanjaJavni = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Potpis\JavniKljuc.txt";
            string putanjaJavniPrivatni = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Potpis\PrivatniKljuc.txt";
            string putanjaPotpis = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Potpis\Potpis.txt";

            string javniPrivatniKljucXML = objektRSA.ToXmlString(true);
            string javniKljucXML = objektRSA.ToXmlString(false);
            SpremiUDatoteku(putanjaJavni, javniKljucXML);
            SpremiUDatoteku(putanjaJavniPrivatni, javniPrivatniKljucXML);

            string sha1ID = CryptoConfig.MapNameToOID("SHA1");
            byte[] potpis= objektRSA.SignData(sazetak, sha1ID);
            SpremiUDatoteku(putanjaPotpis,Convert.ToBase64String(potpis));

            return potpis;
        }

        public bool Provjera(byte[] sazetak) {
            RSACryptoServiceProvider objektRSA = new RSACryptoServiceProvider();

            objektRSA.FromXmlString(ucitaniJavniKljuc);
            string sha1ID = CryptoConfig.MapNameToOID("SHA1");

            return objektRSA.VerifyData(sazetak, sha1ID, potpis);
        }

        public void SpremiUDatoteku(string putanja, string kriptiraniTekst)
        {
            if (!File.Exists(putanja))
            {
                FileInfo file = new FileInfo(putanja);
                file.Directory.Create();
                File.WriteAllText(file.FullName, kriptiraniTekst);
            }
            else if (File.Exists(putanja))
            {
                FileInfo file = new FileInfo(putanja);
                File.WriteAllText(file.FullName, kriptiraniTekst);
            }
        }

    }
}
