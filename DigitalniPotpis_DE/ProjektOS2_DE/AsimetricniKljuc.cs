using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniPotpis
{
    class AsimetricniKljuc
    {
        public string privatniKljuc { get; set; }
        public string Kriptiranje(string izvorniTekst)
        {
            byte [] izvorniTekstUTF8 = Encoding.UTF8.GetBytes(izvorniTekst);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    string putanjaJavni = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Asimetricno\JavniKljuc.txt";
                    string putanjaJavniPrivatni = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Asimetricno\PrivatniKljuc.txt";

                    string javniPrivatniKljucXML = rsa.ToXmlString(true);
                    string javniKljucXML = rsa.ToXmlString(false);
                    SpremiUDatoteku(putanjaJavni, javniKljucXML);
                    SpremiUDatoteku(putanjaJavniPrivatni, javniPrivatniKljucXML);

                    rsa.FromXmlString(javniKljucXML.ToString());

                    byte [] kriptiraniPodaci = rsa.Encrypt(izvorniTekstUTF8, true);

                    string kriptiranoUBazi64 = Convert.ToBase64String(kriptiraniPodaci);

                    return kriptiranoUBazi64;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public string Dekriptiranje(string kriptiraniTekst)
        {
            byte [] kriptiraniPodaci = Encoding.UTF8.GetBytes(kriptiraniTekst);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    string kriptiranoUBazi64 = kriptiraniTekst;

                    rsa.FromXmlString(privatniKljuc.ToString());

                    byte[] konacniBitovi = Convert.FromBase64String(kriptiranoUBazi64);
                    byte[] dekriptiraniBitovi = rsa.Decrypt(konacniBitovi, true);
                    string dekriptiraniPodaci = Encoding.UTF8.GetString(dekriptiraniBitovi);
                    return dekriptiraniPodaci.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
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
