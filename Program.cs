using System;

namespace Methods
{
    class Program
    {
       //Method Overloading
        public int sum(int a,int b)

        {
            return a + b;
        }
        public  int sum(int a, int b,int c)

        {
            return a + b + c;
        }
        //passing perameters by values

        public void AddTwoNumbers(ref int n)
        {
            n += 10;
        } 
        
        public  int result(params int[] listnumber)
        {
            
            int total = 0;
            foreach(int i in listnumber) {
                total = total + i;
            }
            return total;
        }
 
         public static void Main(string[] args)
        {
            Program ob = new Program();
            // int x = ob.sum(40, 60);
            // int y = ob.sum(40, 60,456);
            int a = 45;
            int s = ob.result(34, 67, 89, 232, 45);


            
            ob.AddTwoNumbers(ref a);
            //Console.WriteLine(z);
            //Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(s);
        }
        
    }
}

