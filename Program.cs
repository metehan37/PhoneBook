namespace PhoneBook;
class Program
{
    static void Main(string[] args)
    {
        bool process=false;
        while(process!=true)
        {
            Book book=new Book();//Bu kod ile book sınıfının constructor metodunu çalıştırıyoruz
            //Kullanıcıdan yapması istediği işlemi alıyoruz ve doğru girilmiş mi kontrol ediyoruz
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz :)");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            string Selected=Console.ReadLine();

        //Burada girilen işlem türüne göre yapılacak işlemlerimiz
            switch (Selected)
            {
                //Yeni kişi ekleme 
                case "1":
                {
                    Addperson.Addition(Book.phonelist);
                    break;
                }
                //Numara Silme
                case "2":
                {
                   Deleteperson.Delete(Book.phonelist);
                   break;
                }
                //Güncelleme
                case "3":
                {
                    Updateperson.Update(Book.phonelist);
                    break;
                }
                //Listeleme
                case "4":
                {
                    Callphonebook.Show(Book.phonelist);
                    break;
                }
                //Arama
                case "5":
                {
                   Searchperson.Search(Book.phonelist);
                    break;
                }
                default: 
                {
                    Console.WriteLine("Lütfen düzgün bir değer giriniz!");
                    break;
                }
            }
            Console.WriteLine("Başka bir işlem yapmak isterseniz (1) ");
            Console.WriteLine("Çıkış yapmak isterseniz           (2) ");
            string val=Console.ReadLine();
            switch (val)
            {
                case "1":
                {
                    break;
                }
                case "2":
                {
                    process=true;
                    break;
                }
                
                default: 
                {
                    Console.WriteLine("Yanlış değer girdiniz!");
                    break;
                }
            }
        }
    }
}
