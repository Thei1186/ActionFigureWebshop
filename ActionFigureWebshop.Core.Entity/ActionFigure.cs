using System.Dynamic;
using System.Runtime.InteropServices.ComTypes;

namespace ActionFigureWebshop.Core.Entity
{
    public class ActionFigure
    {
        public int  Id {get;set;}
        public string name { get; set; }
        public double price { get; set;}
        public int size { get; set; }
        public double Weight { get; set; }
        public  string Material { get; set; }
        public  string color { get; set; }
    }
}