using System;

namespace test
{
    class MainClass
    {
		//recursive fibanocci
		public static int  fib(int n)
        {
            if (n<=1)
			{
				return 0;
			}

			 if (n==2)
			{
				return 1;
			}
			else
   			{
				return fib(n - 1) + fib(n - 2);
			    }

		}

        //recursive factorial
        public  static int fact(int n)
		{
			//if (n > 0)
			{


				if (n == 1 || n == 0)
				{
					return 1;
				}

				else
				{
					return fact(n - 1) * n;
				}
			}

		}
		public static void Main(string[] args)
        {
			int[] data = { 10,8,7,1,6,5,2,8};


			int start = 8;
			int end = 1;
			int mid = (start + end) / 2;

			//int p = 0;
			//int c = 1;
			//int store = 0;

            //fibanocci
			//         for (int i = 0; i < start; i++)
			//{
			//	Console.WriteLine(end);
			//	end = c + p;
			//	c = p;
			//	p = end;

			//}

             //factorial
            for (int i = 1; i <=4; i++)
			{
				end = i * end;
			}
			for (int i = 0; i <= data.Length/2; i++)
            {
                start = data[i];
                data[i] = data[data.Length - i - 1];
				data[data.Length - i - 1] = start;
            }

			Console.WriteLine(end);
			for (int i = 1; i <data.Length; i++)
			{
				Console.WriteLine(data[i]);
				//Console.WriteLine(fib(i));
			//	Console.WriteLine(fact(i));
			}

       

		         
           
			Console.ReadLine();

			//int temp = 0;
			//for (int i = 1; i < data.Length; i++)
            {
                //int item = data[i];
               // int ins = 0;
               // for (int j = i - 1; j >= 0 && ins != 1;)
                {
                 //   if (item < data[j])
                    {
                   //     data[j + 1] = data[j];
                  //      j--;
                  //      data[j + 1] = item;
                    }
                //    else ins = 1;
                }
            }


            //selection sort
			//for (int i = 0; i < a.Length; i++)
			{
			//	for (int j = 1; j < a.Length-i; j++)
				{
				//	if (a[i] > a[i+j])
					{
				//		temp = a[i+j];
				//		a[i+j] = a[i];
				//		a[i] = temp;
						//break;
					}

				}
			}



            
			//Console.WriteLine("The Sorted Array :");
            //foreach (int aray in data)
            //    Console.Write(aray + " ");
            //Console.ReadLine();
        }
    }
}
