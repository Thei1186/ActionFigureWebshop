using System.Dynamic;
using System.Runtime.InteropServices.ComTypes;

namespace ActionFigureWebshop.Core.Entity
{
    public class ActionFigure
    {
        public int  Id {get;set;}
        public string Name { get; set; }
        public double Price { get; set;}
        public int Size { get; set; }
        public double Weight { get; set; }
        public  string Material { get; set; }
        public  string Color { get; set; }
        public int Amount { get; set;} // skal flyttes til en order i stedet for
    }
}