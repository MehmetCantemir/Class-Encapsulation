namespace encaosulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Mehmet";
            ogrenci1.Soyaisim = "Cantemir";
            ogrenci1.OgrNo = 4033;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2=new Ogrenci();
            ogrenci2.Isim = "Sedef";
            ogrenci2.Soyaisim = "Cantemir";
            ogrenci2.OgrNo = 1231;
            ogrenci2.Sinif = 1;
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();


        }
    }

    class Ogrenci
    {
        private string isim;

        private string soyaisim;

        private int ogrNo;

        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyaisim { get => soyaisim; set => soyaisim = value; }
        public int OgrNo { get => ogrNo; set => ogrNo = value; }
        public int Sinif {
            get => sinif; 
            set 
            {
               if(value<1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir.");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

       
        public Ogrenci (string isimi , string soyisim , int ogrenciNo , int sinifi){
            this.Isim = isimi;
            this.Soyaisim = soyisim;
            this.Sinif = sinifi;
            this.OgrNo = ogrenciNo;
        }
        public Ogrenci() { }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("************ Öğrenci Bilgileri *****************");
            Console.WriteLine("Ogrenci adı : "+this.Isim);
            Console.WriteLine("Ogrenci SoyAdı : "+ this.Soyaisim);
            Console.WriteLine("Ogrenci No : "+this.OgrNo);
            Console.WriteLine("Ogrenci Sınıfı : "+ this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif=this.Sinif - 1;
        }
    }
}