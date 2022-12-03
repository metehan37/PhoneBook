namespace PhoneBook;

public class Searchperson
{
    public static void Search(List<Phone_Book> phones)
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        int val=Int16.Parse(Console.ReadLine());
        switch (val)
        {
            case 1:
            {
                Console.Write("İsim yada soyisim giriniz: ");
                string value=Console.ReadLine();
                foreach (var item in phones)
                {
                    if (item.Name == value || item.Surname== value)
                        {
                            Console.WriteLine("İsim: {0}",item.Name);
                            Console.WriteLine("Soyisim: {0}",item.Surname);
                            Console.WriteLine("Numara: {0}",item.Number);
                            Console.WriteLine("-");
                        }
                }
                break;
            }
            case 2:
            {
                Console.Write("Numara giriniz: ");
                string value=Console.ReadLine();
                foreach (var item in phones)
                {
                    if (item.Number == value)
                        {
                            Console.WriteLine("İsim: {0}",item.Name);
                            Console.WriteLine("Soyisim: {0}",item.Surname);
                            Console.WriteLine("Numara: {0}",item.Number);
                            Console.WriteLine("-");
                        }
                }
                break;
            }
            
            default: 
            {
                Console.WriteLine("Geçerli bir değer giriniz!!!");
                break;
            }
        }
    }
}