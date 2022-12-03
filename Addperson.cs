namespace PhoneBook;

public class Addperson
{
    public static void Addition(List<Phone_Book> phonelist)
    {
        Console.Write(" Lütfen isim giriniz            :");
        string name=Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          :");
        string surname=Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz :");
        string number=Console.ReadLine();
        Phone_Book phone =new Phone_Book(name,surname,number);
        Book.phonelist.Add(phone);
    }

}