int a = 2;
            int count = 1;

            while (count < 10)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (a < 10)
                    {
                        if(i < 10)
                        {
                            Console.WriteLine(a + " x " + i + "=" + (a*i));
                            if(i == 9)
                                a++;                  
                        }
                    }                
                }
                count++;
            }


for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }