namespace PhoneBook;

public class Phone_Book
{
    private string name;
    private string surname;
    private string number;

    public Phone_Book(string name, string surname, string number)
        {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public string Number { get => number; set => number = value; }
}