using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    internal class Rectangle: Shape
    {

        /*public Rectangle(double x): base(x) { 
        }*/
        
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
