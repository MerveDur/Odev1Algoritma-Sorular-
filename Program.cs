// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0,i=0,num=0;
            Console.WriteLine("Enter a positive number for n: ");
            n=Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            
            if(n>0)
            {
                for(i=0;i<n;i++)
                {
                    
                    num =Convert.ToInt32(Console.ReadLine());
                    numbers[i]=num;
                }
                Console.WriteLine("The even numbers: ");
                for(i=0;i<n;i++)
                {
                    if(numbers[i]%2==0)
                    {    
                        Console.WriteLine(numbers[i]+" ");                    
                    }
                }
                
            }
            
        }
    }
}
