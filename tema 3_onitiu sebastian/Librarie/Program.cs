using System;
using System.Collections.Generic;

namespace Librarie
{
    class Article 
    {
        protected int ArticleNumber, PageNumber;
        protected string Title,Author;
        protected bool isAvailable;
        public string GetAuthor()
        {
            return Author;
        }

        public string GetTitle()
        {
            return Title;
        }

        void DisplayDetails()
        {
            Console.Write($"Title: {Title} \n Article number: {ArticleNumber} \n Page number: {PageNumber}" +
                $"Availability: {isAvailable}");
        }

        protected string ReadIt()
        {
            return Title;
        }
        public Article()
        {
            this.ArticleNumber = 0;
            this.PageNumber = 0;
            this.Title = "";
            this.isAvailable = false;
            this.Author = "";
        }
        public Article(int ArticleNumber, int PageNumber, string Title)
        {
            this.ArticleNumber = ArticleNumber;
            this.PageNumber = PageNumber;
            this.Title = Title;
        }
        public Article(int ArticleNumber, int PageNumber, string Title,string Author)
        {
            this.ArticleNumber = ArticleNumber;
            this.PageNumber = PageNumber;
            this.Title = Title;
            this.Author = Author;
        }
        
    }

    class Magazine:Article 
    {
        private int MagazineNumber, Edition,Frequency;
        public Magazine(int ArticleNumber, int PageNumber, int Edition, int Frequency, string Title) : base(ArticleNumber, PageNumber, Title)
        {
            this.ArticleNumber = ArticleNumber;
            this.PageNumber = PageNumber;
            this.Edition = Edition;
            this.Frequency = Frequency;
            this.Title = Title;
        }
        bool HasSubscribers(int Edition)
        {
            if (Edition > 10)
            {
                return true;
            }
            else return false;
        }
    }


    class Book : Article 
    {
        private string PublishingHouse, CoverType;
        private int Year;
        public Book(int ArticleNumber, string Title, string Author, string PublishingHouse, int PageNumber,
                int Year, string CoverType) : base(ArticleNumber, PageNumber, Title,Author)
        {
            this.ArticleNumber = ArticleNumber;
            this.Title = Title;
            this.PublishingHouse = PublishingHouse;
            this.PageNumber = PageNumber;
            this.Year = Year;
            this.CoverType = CoverType;
            this.Author = Author;
        }

        public Book(Book book)
        {
            this.ArticleNumber = book.ArticleNumber;
            this.Title = book.Title;
            this.Author = book.Author;
            this.PublishingHouse = book.PublishingHouse;
            this.PageNumber = book.PageNumber;
            this.Year = book.Year;
            this.CoverType = book.CoverType;
        }
    }
    class Library
    {
        private string Name, Adress, City;
        private int EmployeesNumber;
        List<Article> AvailableArticles;
        private List<Article> GetAllArticles()
        {
            return AvailableArticles;
        }
        private void DisplaySchedule()
        {
            Console.Write($"Name: {Name} \n Adress: {Adress} \n City: {City}" +
                $"EmployeesNumber: {EmployeesNumber} \n Scheledule: Monday to Friday, 8:00 - 18:00 \n");
        }
        private List<string> GetAllAuthors()
        {
            List<string> ListOfAuthors = new List<string>();
            foreach (Article AvailableArticle in AvailableArticles)
            {
                ListOfAuthors.Add(AvailableArticle.GetAuthor());
            }
            return ListOfAuthors;
        }
        private List<string> DisplayAllBooks()
        {
            List<string> ListOfBooks = new List<string>();
            foreach (Article AvailableArticle in AvailableArticles)
            {
                if (AvailableArticle is Book)
                {
                    Console.WriteLine($"\n{AvailableArticle.GetTitle()}");
                }
            }
            return ListOfBooks;
        }

        private List<string> DisplayAllMagazine()
        {
            List<string> ListOfMagazine = new List<string>();
            foreach (Article AvailableArticle in AvailableArticles)
            {
                if (AvailableArticle is Magazine)
                {
                    Console.WriteLine($"\n{AvailableArticle.GetTitle()}");
                }
            }
            return ListOfMagazine;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
