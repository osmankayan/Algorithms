using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderbyte
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        public static string NearestSmallerValues(int[] arr)
        {
            string z = string.Empty;
            int[] list = new int[arr.Length];
            int c = 0;
            for (int a = arr.Length-1; a >= 0; a--)
            {
                for (int b = 1; true; b++)
                {
                    if (a - b < 0)
                    {
                        list[c] = -1;
                        c++;
                        break;
                    }
                    else if (arr[a - b] < arr[a] && a-b>=0)
                    {
                        list[c] = arr[a-b];
                        c++;
                        
                        break;
                        
                    }
                     

                    else
                    {
                        continue;
                    }
                }
                
            }

            Array.Reverse(list);
            foreach (int item in list)
            {
                z += item + " ";
                //Console.Write(item + " ");
            }
            return z;
            
        }
        public static string NumberReverse(string str)
        {

            str=str.Replace('"', ' ');
            str=str.Trim();
            string[] value = str.Split(' ');
            int[] value2 = Array.ConvertAll(value, int.Parse);
            for (int i = value2.Length-1; i >= 0 ; i--)
            {
                Console.Write(value2[i]+" ");
            }
            return "a";
            
            

        }
        public static string LineOrdering(string[] strArr)
        {

            for (int i = 0; i < strArr.Length; i++)
            {
                //strArr[0].
            }
            return strArr[0];

        }
        public static string FibonacciChecker(int num)
        {
            int[] dizi = new int[99];
            dizi[0] = 1;
            dizi[1] = 2;


            int a=0;
            for (int i = 2; a < num-1; i++)
            {
                dizi[i] = dizi[i - 2] + dizi[i - 1];
                a = dizi[i];
            }
            if (a == num)
            {
                return "yes";
            }
            else return "no";
            

           
               

        }
        public static bool HappyNumbers(int num)
        {

            string num1 = num.ToString();
            double toplam=0.0;
            for (int i = 0; i < num1.Length; i++)
            {
                string x = num1[i].ToString();
                int a = Convert.ToInt32(x);


                toplam += Math.Pow(a, 2);
            }
            if (Convert.ToInt32(toplam) == 1) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void CountingMinutes(string str)
        {
            str=str.Replace('"',' ');
            string[] value = str.Split('-');
            DateTime end = DateTime.Parse(value[1]);
            DateTime start = DateTime.Parse(value[0]);
            if (start > end)
                end= end.AddDays(1);
            TimeSpan difference = end.Subtract(start);
            var ab = difference;
            int minutes = ab.Hours * 60+ab.Minutes;
            
            Console.WriteLine(minutes.ToString());



        }
        public static void SimpleEvens(long num)
        {

           string num1=num.ToString();
            int abc = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                int a = Convert.ToInt32(num1[i]);
                if (a % 2 != 0 )
                {
                    abc++;
                }
                

            }
            if (abc > 0)
            {
                Console.WriteLine("false");
            }
            else Console.WriteLine("true");


        }
        public static void TwoSum(int[] arr)
        {

            int main = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {

                for (int b = 2; b < arr.Length; b++)
                {

                    if (arr[i] + arr[b] == main && b > i)
                    {
                        Console.Write("{0},{1} ", arr[i], arr[b]);
                    }


                }


            }



        }
        public static void ArrayCouples(int[] arr)
        {
            int aaa = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                for (int b = 3; b < arr.Length; b += 2)
                {
                    if (arr[i] == arr[b] && arr[i + 1] == arr[b - 1])
                    {
                        aaa = 1;

                    }


                }

            }
            int bbb = 0;
            for (int i = 2; i < arr.Length; i += 2)
            {
                for (int b = 5; b < arr.Length; b += 2)
                {
                    if (arr[i] == arr[b] && arr[i + 1] == arr[b - 1])
                    {
                        bbb = 1;

                    }


                }

            }
            int ccc = 0;
            for (int i = 4; i < arr.Length; i += 2)
            {
                for (int b = 7; b < arr.Length; b += 2)
                {
                    if (arr[i] == arr[b] && arr[i + 1] == arr[b - 1])
                    {
                        ccc = 1;

                    }


                }

            }
            if (aaa + bbb + ccc == 2) Console.WriteLine("yes");



        }
        public static int PowerSetCount(int[] arr)
        {


            int arrlengt = 0;
            foreach (var item in arr)
            {
                arrlengt++;
            }
            for (int i = 0; i < arrlengt; i++)
            {

            }
            int result = Convert.ToInt32(Math.Pow(2, arrlengt));
            return result;
            //int a = arr.Length;


        }
        public static string EvenPairs(string str)
        {
            char[] ab = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                ab[i] = str[i];
            }
            Array.Reverse(ab);
            if (ab[0] % 2 == 0)
            {
                return "true";
            }
            else return "false";
            
            

    

        }

        public static int ThreeFiveMultiples(int num)
        {

            int three = 0;
            for (int i = 3; i < num; i += 3)
            {
                three += i;
            }
            int five = 0;
            for (int b = 5; b < num; b += 5)
            {

                five += b;
            }
            int toplam = three + five;
            return toplam;

        }
        public static void ParallelSums(int[] arr)
        {

            int toplam = 0;
            foreach (int item in arr)
            {

                toplam += item;
            }


            if (toplam % 2 == 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int b = i + 1; b < arr.Length - i; b++)
                    {
                        if (arr[i] + arr[b] == toplam / 2)
                        {
                            Console.Write("{0},{1}", arr[i], arr[b]);
                            if (arr[i] == 1)
                            {
                                Console.Write(",");
                            }
                        }
                    }


                }

            }


            else Console.WriteLine("-1");


        }
    }
}
