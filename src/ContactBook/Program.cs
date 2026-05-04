namespace ContactBook;

public class Program
{
    public static void Main()
    {
        var c1 = new Contact("Henry", "Bruckman", "123-456-7890", "hbruckman@gmail.com");
        var c2 = new Contact("Alice", "Smith", "987-654-3210", "asmith@gmail.com");
        var cb = new ContactBook(new List<Contact> { c1, c2 });
        cb.Start();
    

    }
}


