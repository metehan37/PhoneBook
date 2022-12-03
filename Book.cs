namespace PhoneBook;

public class Book
{
    //Verilerimizi tutacağımı listemizi oluşturuyoruz ve 5 değer varsayılan olarak atıyoruz.
    public static List<Phone_Book> phonelist= new List<Phone_Book>();
    public Book()
    {
        Phone_Book phone1=new Phone_Book("Metehan","Metinoğlu","5051235656");
        Phone_Book phone2=new Phone_Book("Ömer","Cebeci","5052335656");
        Phone_Book phone3=new Phone_Book("Ümit","Demir","5251235656");
        Phone_Book phone4=new Phone_Book("Tufan","Özçelik","5151235656");
        Phone_Book phone5=new Phone_Book("Emriye","Demirci","5351235623");
        phonelist.Add(phone1);
        phonelist.Add(phone2);
        phonelist.Add(phone3);
        phonelist.Add(phone4);
        phonelist.Add(phone5);
    }

}