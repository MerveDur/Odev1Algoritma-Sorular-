// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0,i=0,num=0,m=0,n2=0,letter=0;
            Console.WriteLine("Question 1: ");
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
            Console.WriteLine("Question 2: ");
            Console.WriteLine("Enter a positive number for m: ");
            Console.WriteLine("Enter a positive number for n: ");
            m=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());
            int[] numbers2 = new int[n2];
            if(n2>0)
            {
                for(i=0;i<n2;i++)
                {
                    num =Convert.ToInt32(Console.ReadLine());
                    numbers2[i]=num;
                }
                Console.WriteLine("Result: ");
                for(i=0;i<n2;i++)
                {
                    if(numbers2[i]%m==0)
                    {    
                        Console.WriteLine(numbers2[i]+" ");                    
                    }
                } 
            }
            Console.WriteLine("Question 3: ");
            Console.WriteLine("Enter a positive number for n: ");
            n=Convert.ToInt32(Console.ReadLine());
            string[] words=new string[n];
            if(n>0)
            {
                for(i=0;i<n;i++)
                {
                    string? str=Console.ReadLine();
                    if(str!=null)
                    {
                        words[i]=str;
                    }
                    
                }
                Console.WriteLine("Reverse Words");
                for(i=n-1;i>=0;i--)
                {
                    Console.WriteLine(words[i]+" ");                    
                    
                } 
            }
            Console.WriteLine("Question 4: ");
            string? sentence=Console.ReadLine();
            var numberOfWords = sentence.Split(' ',StringSplitOptions. RemoveEmptyEntries).Length;
            Console.WriteLine("Question 4: "+numberOfWords);
            for(i=0;i<sentence.Length;i++)
            {
                if(Char.IsLetter(sentence[i])==true)
                    letter++;                                 
            } 
            Console.WriteLine(letter);
        }
    }
}
