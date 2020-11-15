using System;

namespace GradeBook
{
    //class Book
    //{
    //}

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Book One");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            //book.grades.Add(101);

            book.ShowStatistics();
        }
    }
}
