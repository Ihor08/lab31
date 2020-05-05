using System;
namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введіть набір слів");
            string a = Console.ReadLine();
            char[] b = a.ToCharArray();
            int n = 0;
            char[] golosni = { 'а', 'о', 'у', 'ю', 'я', 'е', 'є', 'и', 'і', 'ї' };
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < golosni.Length; j++)
                {
                    if (i == 0 && b[i] == golosni[j])
                    {
                        n++;
                    }

                    if ((i > 0) && (b[i - 1] == ' ') && (b[i] == golosni[j]))
                    {
                        n++;
                    }

                }


            }


            Console.WriteLine("n = " + n);
            int m = 0;// кількість приголосних в одному слові
            int p = 0;//кількість слів з непарною кількістю приголосних в тому слові

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < golosni.Length; j++)
                {

                    if (b[i] == ' ')
                    {
                        if (m % 2 != 0)

                        {

                            m = 0; p++;

                            break;


                        }
                        else
                        {
                            m = 0;

                            break;
                        }
                    }
                    if (b[i] != golosni[j])
                    {
                        m++;

                        break;

                    }




                }
                if (i == b.Length - 1)
                {
                    if (m % 2 != 0)

                    {

                        m = 0; p++;




                    }
                    else
                    {
                        m = 0;


                    }
                }

            }
            Console.WriteLine("P = " + p);
        }
    }
}
