using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Example
{
    class Book
    {
        private string strTitle;
        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }
        private float fltPrice;
        public float Price
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }
        public Book()
        {
        }
        public Book(string strTitle, float fltPrice)
        {
            this.strTitle = strTitle;
            this.fltPrice = fltPrice;
        }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book objBook1, objBook2;
            objBook1 = new Book();
            Console.Write("Enter title of book1: ");
            string Title1 = Console.ReadLine();
            Console.Write("Enter price of book1: ");
            float Price1 = float.Parse(Console.ReadLine());
            objBook1.Title = Title1;
            objBook1.Price = Price1;

            Console.Write("Enter title of book2:");
            string Title2=Console.ReadLine();
            Console.Write("Enter price of book2:");
            float Price2= float.Parse(Console.ReadLine());
            objBook2 = new Book(Title2, Price2);
            Console.WriteLine("book1: Title is {0}, Price is: {1}", objBook1.Title, objBook1.Price);
            Console.WriteLine("book2: Title is {0}, Price is: {1}", objBook2.Title, objBook2.Price);

        }
        
    }
}
