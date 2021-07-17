using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assq3
{
    class Program
    {
        static int isprime(int n)
        {
            if (n <= 1)
                return 0;
            if (n <= 3)
                return 1;
            if (n % 2 == 0 || n % 3 == 0)
                return 0;
            for(int i =5; i*i <=n;i=i+6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return 0;
            }
            return 1;
        }
        static int countP(int N)
        {
            int count = 0;
            List<int> arr = new List<int>();

            for(int i =2;i<=N;i++)
            {
                if(isprime(i)==1)
                {
                    arr.Add(i);
                }
            }

            int sum = 0;
            for(int i=0;i<arr.Count;i++)
            {
                sum += arr[i];
                if (sum <= N)
                    count++;
               // if (isprime(sum) == 1)
               //     count++;

            }
            return count;
        }
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("enter number below 100");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(countP(N));
        }

        
    }
}
