using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMax3000
{
    public class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();
        }

        public void AddMenuItem(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            items.Add(item);
        }
        public string Name;
        public List<MenuItem> items;
    }
}
