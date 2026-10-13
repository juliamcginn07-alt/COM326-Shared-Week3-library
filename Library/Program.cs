using Library;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        books.Add(new Book("C# for beginners", "Bill Gates", "1234567"));
        books.Add(new Book("Ultimate c#", "Microsoft", "2233445"));

        members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
        members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

        foreach (Member member in members)
        {
            member.DisplayInfo();
        }

        foreach (Book book in books)
        {
            book.DisplayInfo();
        }
    }
}

