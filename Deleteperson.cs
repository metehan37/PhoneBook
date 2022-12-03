namespace PhoneBook;

public class Deleteperson
{
    public static void Delete(List<Phone_Book> phones)
    {
        bool process=false;
        while(process!=true)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string val =Console.ReadLine();
            foreach (Phone_Book item in phones)
            {
                if (item.Name == val || item.Surname== val)
                {
                    Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",item.Name);
                    char ok=char.Parse(Console.ReadLine());
                    if (ok=='y')
                    {
                        Book.phonelist.Remove(item);
                        process=true;
                        break;  
                    }
                    else
                    {
                        process=true;
                        break;
                    }

                }
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