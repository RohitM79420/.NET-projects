using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class TwoDshape
    {
        double pri_width;
        double pri_height;
        String pri_name;
        public TwoDshape(double w, double h, string s) 
        {
            width = w;
            height = h;
            name = s;
            Console.WriteLine("In TwoDshape constructor");
        }

        public abstract double area();

        public double width
        {
            get { return pri_width; }   
            set { pri_width = value; }
        }
        public double height
        {
            get { return pri_height; }
            set { pri_height = value; }
        }
        public string name
        {   get { return pri_name; }
            set { pri_name = value; } 
        }
        public void showDim()
        {
            Console.WriteLine("Width and Height are "+width+" and "+height);
        }
        

    }
    class Triangle : TwoDshape
    {
        public Triangle(double w , double h ): base(w,h,"Triangle" )
        {
            Console.WriteLine("In Triangle Constructor");
        }
        public override double area()
        {
            return width *height/2;
        }
    }
    class Rectangle : TwoDshape
    {
        public Rectangle(double w, double h) : base(w, h, " Rectangle")
        {
            Console.WriteLine("In Rectangle Constructor"); 
        }
        public override double area()
        {
            return width *height ;
        }
    
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoDshape[]shapes= new TwoDshape[2];
            shapes[0] = new Triangle(5.5,3.4);
            shapes[1] = new Rectangle(10, 4);

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].area();
                Console.WriteLine("Area of "+shapes[i].name);
                Console.WriteLine(shapes[i].area());
            }
            TwoDshape d= new Triangle(5,7);
            d.showDim();
            Console.ReadLine();


        }
    }
}
