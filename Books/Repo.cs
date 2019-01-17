using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books
{
    public class Repo
    {
        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            List<string> images = new List<string>();
            List<string> sounds = new List<string>();
            try
            {
                images.Add("http://mekonetolrom.com/Images/campus1.jpg");
                images.Add("http://mekonetolrom.com/Images/campus2.jpg");
                images.Add("http://mekonetolrom.com/Images/campus3.jpg");
                images.Add("http://mekonetolrom.com/Images/campus4.jpg");
                images.Add("http://mekonetolrom.com/Images/campus5.jpg");

                sounds.Add("http://mekonetolrom.com/Images/audio1_english.mp3");
                sounds.Add("http://mekonetolrom.com/Images/audio1_english.mp3");
                sounds.Add("http://mekonetolrom.com/Images/audio1_english.mp3");
                sounds.Add("http://mekonetolrom.com/Images/audio1_english.mp3");
                sounds.Add("http://mekonetolrom.com/Images/audio1_english.mp3");

                book1.Id = "1";
                book1.Author = "Mekone Tolrom";
                book1.Language = "French";
                book1.Text = "Earn a role-based certification that shows you are keeping pace "
                    + "with today’s technical roles and requirements. Skill up, prove your "
                    + "expertise to employers and peers, and get the recognition and "
                    + "opportunities you’ve earned.";
                book1.Title = "Snowwhite";
                book1.Images = images;
                book1.Sounds = sounds;

                book2.Id = "2";
                book2.Author = "Maria Conte";
                book2.Language = "Arabic";
                book2.Text = "Earn a role-based certification that shows you are keeping pace "
                    + "with today’s technical roles and requirements. Skill up, prove your "
                    + "expertise to employers and peers, and get the recognition and "
                    + "opportunities you’ve earned.";
                book2.Title = "Breaking Bad";
                book2.Images = images;
                book2.Sounds = sounds;

                book3.Id = "3";
                book3.Author = "Gerlad Smith";
                book3.Language = "English";
                book3.Text = "Earn a role-based certification that shows you are keeping pace "
                    + "with today’s technical roles and requirements. Skill up, prove your "
                    + "expertise to employers and peers, and get the recognition and "
                    + "opportunities you’ve earned.";
                book3.Title = "Home Alone";
                book3.Images = images;
                book3.Sounds = sounds;

                books.Add(book1);
                books.Add(book2);
                books.Add(book3);

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            return books;
        }
    }
}