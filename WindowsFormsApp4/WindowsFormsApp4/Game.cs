using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    [Serializable]
    public class Game
    {
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Notation { get; set; }
        public string Kategory { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public DateTime Release { get; set; } 
        public string Platform { get; set; }

        public override string ToString()
        {
            return string.Format("Название: {0}, Категория: {1}, Рейтинг: {2}, Цена: {3}, Производитель: {4}, " +
                "Дата релиза: {5}, Платформа: {6}", ShortName, Kategory, Rating, Price, Publisher, Release, Platform);
        }
        public Game() { }
        public Game(string shortName, string fullName, string notation, string kategory, int rating, double price, string publisher, DateTime release, string platform)
        {
            ShortName = shortName;
            FullName = fullName;
            Notation = notation;
            Kategory = kategory;
            Rating = rating;
            Price = price;
            Publisher = publisher;
            Release = release;
            Platform = platform;
        }
    }
    [Serializable]
    public class Games
    {
        public List<Game> GamesList { get; set; } = new List<Game>();
    }
}
