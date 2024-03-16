int num = 95; //소수 5 7 11 13 17 ...

            bool isPrime = true;

            for(int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("소수입니다.");
            else
                Console.WriteLine("소수가 아닙니다.");


for (int i = 0; i < 100; i++)
            {
                if ((i % 3) != 0)
                    continue;
                
                    Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
                
            }