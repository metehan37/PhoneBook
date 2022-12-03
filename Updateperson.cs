namespace PhoneBook;

public class Updateperson
{
    public static void Update(List<Phone_Book> phonelist)
    {
        bool process=false;
        Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string val =Console.ReadLine();
        while (process!=true)
        {
            bool find=false;
            while (find!=true)
            {
                foreach (Phone_Book item in phonelist)
                {
                    if (item.Name == val || item.Surname== val)
                    {
                        Console.Write(" Lütfen yeni isim giriniz            :");
                        item.Name=Console.ReadLine();
                        Console.Write("Lütfen yeni soyisim giriniz          :");
                        item.Surname=Console.ReadLine();
                        Console.Write("Lütfen yeni telefon numarası giriniz :");
                        item.Number=Console.ReadLine();
                        process=true;
                        find=true;
                        break;
                    }
                }
                if (find)
                {
                    break;
                }
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int val2=Int16.Parse(Console.ReadLine());
                switch (val2)
                {
                    case 1: 
                    {
                        process=true;
                        break;
                    }
                    case 2: break;
                    default:
                    {
                        Console.WriteLine("yanlış değer girdiniz...");
                        break;
                    }
                } 
            }
        }
    }
            
}