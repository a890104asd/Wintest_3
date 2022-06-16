using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int[] num = new int[N];
            int i;
            Console.WriteLine("輸入10個數字");
            try
            {
                for (i = 0; i < num.Length; i++){
                    num[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (i = 0; i < N; i++)
                {
                    for(int j = i + 1; j < N; j++)
                    {
                        if (num[j] < num[i])
                        {
                            int temp = num[i];
                            num[i] = num[j];
                            num[j] = temp;
                        }
                    }
                }
                Console.WriteLine("結果：");
                foreach(int temp in num){
                    Console.Write("{0,-4}", temp);
                    
                }
                Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.Write("錯誤：{0}",e);
            }
        }
    }
}
