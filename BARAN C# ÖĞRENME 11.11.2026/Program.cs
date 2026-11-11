using System.Reflection;
using System.Security.AccessControl;
using static System.Reflection.Metadata.BlobBuilder;

namespace BARAN_C__ÖĞRENME_11._11._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book b1 = new Book("Simyacı", "Paulo Coelho");

            books.Add(b1);
            books.Add(new Book("Suç ve Ceza ", "Dostoyevski"));
            Console.WriteLine("1-KİTAP EKLE");
            Console.WriteLine("2-KİTAPLARI LİSTELE");
            Console.WriteLine("3-KİTAP ARA");
            Console.WriteLine("4-KİTAP SİL");

            Console.WriteLine("0-ÇIKIŞ");
            Console.Write("SEÇİMİNİZ:");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 0)
            {
                if (choice == 1)
                {
                    Console.Write("KİTAP ADI:");
                    string title = Console.ReadLine();
                    Console.Write("YAZAR ADI:");
                    string author = Console.ReadLine();
                    books.Add(new Book(title, author));

                    Console.WriteLine("Kitap eklendi !");


                }
                else if (choice == 2)
                {




                    for (int i = 0; i < books.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {books[i].Title} - {books[i].Author}");


                    }

                }
                else if (choice == 3)
                {
                    Console.Write("ARANACAK KİTAP:");
                    string search = Console.ReadLine();

                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].Title == search)
                        {

                            Console.WriteLine($"BULUNDU:{books[i].Title}-{books[i].Author}");

                        }

                    }

                }
                else if (choice == 4)
                {
                    Console.Write("Silinecek kitabın numarası:");
                    int delete = int.Parse(Console.ReadLine());
                    books.RemoveAt(delete - 1);
                    Console.WriteLine("Kitap silindi");
                }

                Console.WriteLine("1-KİTAP EKLE");
                Console.WriteLine("2-KİTAPLARI LİSTELE");
                Console.WriteLine("3-KİTAP ARA");
                Console.WriteLine("4-KİTAP SİL");

                Console.WriteLine("0-ÇIKIŞ");
                Console.Write("SEÇİMİNİZ:");
                choice = int.Parse(Console.ReadLine());











            }
            Console.WriteLine("GÖRÜŞÜRÜZ!");


        }


    }
}

class Book
{

    public string Title { get; set; }

    public string Author { get; set; }
    public Book(string title, string author)
    {
        Title = title;
        Author = author;




    }

}






























