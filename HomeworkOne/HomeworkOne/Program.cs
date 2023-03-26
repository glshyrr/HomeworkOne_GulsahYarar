// See https://aka.ms/new-console-template for more information
using HomeworkOne.Models;
Console.WriteLine("Hello, World!");
//Book book = new Book()
//{
//    Title = "Steve Jobs",
//    Author = "Walter Isacson",
//    PublisherName = "Domingo Yayınevi",
//};
//Publisher publisher = new Publisher()
//{
//    PbName = "Domingo Yayınevi",
//    BookName = "Steve Jobs",
//};

//BookDataContext db = new BookDataContext();
//db.Books.Add(book);
//db.Publishers.Add(publisher);
//db.SaveChanges();

BookDataContext bookDb = new BookDataContext();

var book = bookDb.Books.Where(x => x.Id > 1).FirstOrDefault();

//var Book = bookDb.Books.Where(s => s.Title == "Steve Jobs").FirstOrDefault();
//book.Author = "Walter Isaacson";

//bookDb.SaveChanges();