namespace ResearchByTwitter
{
    public class Program
    {
        public void checkTheSquare(int height,int width)
        {
            if(height == width || Math.Abs(height - width) > 5)           
                Console.WriteLine("The area is " + height * width);       
            else
                Console.WriteLine("The scope is " + width * 2 + height * 2);
        }
        public void checkTheTriangle(int height,int width)
        {
            Console.WriteLine();
            Console.WriteLine("for calculate the scope press 1\nfor print the triangle press 2");
            int input=Convert.ToInt32(Console.ReadLine());
            switch(input) 
            {
                case 1: Console.WriteLine("The scope is" + 
                    width + 
                    2 * Math.Sqrt(
                    Math.Pow(width / 2 , 2) + 
                    Math.Pow(height , 2))); 
                    break;
                case 2: if (width % 2 == 0 || width > 2 * height)
                            Console.WriteLine("The triangle cannot be printed!");
                        else
                            printTriangle(width,height);
                    break;
            }
        }
        public void printTriangle(int width,int height)
        {          
            double num = (width - 2) / 2;
            bool more = ((((height-2) / num) % 1) * 10 == 0) ? false : true;
            double countOfTimes = (height-2) / num ;
            for (int i = 1;i <= num + 2; i++) 
            {
                switch(i)
                {
                    case 1:doTimes(1,i,width,height); break;
                    case var x when x == num + 2: doTimes(1,i,width,height);break;
                    case 2:if(more) doTimes(countOfTimes+1, i, width, height); 
                           else doTimes(countOfTimes, i, width, height); break;
                    default:
                        doTimes(countOfTimes,i,width,height); break;
                }              
            }
            Console.WriteLine();
        }
        public void doTimes(double sumOfTimes,int i,int width,int height)
        {
            while((int)sumOfTimes>0)
            {
                int spaces = (width - (2 * i - 1)) / 2;
                for (int j = 1; j <= width; j++)
                {
                    if (j <= spaces || j > spaces + 2 * i - 1)
                        Console.Write(" ");
                    else
                        Console.Write("*");

                }
                Console.WriteLine();
                sumOfTimes--;
            }             
        }
        //main
        static void Main(string[] args)
        {
            Program program = new Program();
            

            int height, width;
            Console.WriteLine("welcome to the research!");
            Console.WriteLine("for square press 1\nfor triangle press 2\nfor exit press 3");
            int choose= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (choose!=3)
            {
                Console.WriteLine("enter the height of your tower");
                height=Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("enter the wisth of your tower");
                width = Convert.ToInt32(Console.ReadLine());
                switch (choose) 
                { 
                   
                    case 1: program.checkTheSquare(height,width);   break;
                    case 2: program.checkTheTriangle(height,width); break;
                }
                Console.WriteLine();
                Console.WriteLine("for square press 1\nfor triangle press 2\nfor exit press 3");
                choose = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("bye");

        }
    }
}