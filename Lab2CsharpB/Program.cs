using System;

namespace Lab2CsharpB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of quadrangles:");
            int N = 0;
            bool isCorrect;
            do
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out N);
                if (!isCorrect) { Console.WriteLine("Wrong entering."); }
            } while (!isCorrect);

            double avgsqure = 0;
            double min = 0;
            double max = 0;

            Triangle[] tring = new Triangle[N];


            for (int i = 0; i < N; i++)
            {
                do
                {
                    tring[i] = new Triangle();
                    tring[i].Lenght();
                    tring[i].IsExists();
                    if (tring[i].exist == true)
                    {
                        tring[i].Print();
                        tring[i].Angle();
                        tring[i].Perimetr();
                        tring[i].Square();
                    }
                } while (tring[i].exist == false);

                min = tring[0].perimetr;
                avgsqure += tring[i].square;
                
                Console.WriteLine("----------------------------------");
            }
            avgsqure /= N;

            Console.WriteLine($"Average Square = {avgsqure}");

            for (int i = 0; i < N; i++)
            {
                if (tring[i].perimetr < min)
                {
                    min = tring[i].perimetr;
                }

            }
            Console.WriteLine($"Minimum of perimetr = {min}");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Enter the number of Right Triangle:");
            int M = 0;
            do
            {
                isCorrect = Int32.TryParse(Console.ReadLine(), out M);
                if (!isCorrect) { Console.WriteLine("Wrong entering."); }
            } while (!isCorrect);
            RightTriangle[] all = new RightTriangle[M];

            for (int i = 0; i < M; i++)
            {
                do
                {
                    all[i] = new RightTriangle();
                    all[i].Lenght();
                    all[i].IsExists();
                    if (all[i].exist)
                    {
                        if (all[i].isRight())
                        {
                            all[i].Print();
                            all[i].Angle();
                            all[i].Perimetr();
                            all[i].Square();
                        }
                    }
                } while (!all[i].isRight() || !all[i].exist);
                Console.WriteLine("----------------------------------");

            }
            int count=0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (all[i].lenght[j] > max)
                    {
                        max = all[i].lenght[j];
                        count++;
                    }
                }
            }
            Console.WriteLine($"Maximum of hypotenuse = {count}");

        }
    }
}
