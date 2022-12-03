namespace PhoneBook;

public class Callphonebook
{
    public static void Show(List<Phone_Book> phonelist)
    {
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("**************************");
        foreach (var item in phonelist)
        {
           Console.WriteLine("İsim: {0}",item.Name);
           Console.WriteLine("Soyisim: {0}",item.Surname);
           Console.WriteLine("Numara: {0}",item.Number);
           Console.WriteLine("-");
        }
    }
}