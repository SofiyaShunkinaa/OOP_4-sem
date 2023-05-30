

using System.Collections.Generic;

public class Flower
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Family { get; set; }
        public int Price { get; set; }
        
        public Flower(int Id, string Title, string Family, int Price)
        {
            this.Id = Id;
            this.Title = Title;
            this.Family = Family;
            this.Price = Price;
        }

    public Flower() { }
    }


