using System;

namespace BasicThirteen
{
    class Program
    {
        static void TwoFiftyFive()
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
}
        static void OddThousand()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void OneToFiveThousand()
        {
            int sum = 0;
            for (int i = 1; i <= 5000; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void ArrayIteration()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void MaxValue()
        {
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7 };
            int MaxVal = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > MaxVal)
                {
                    MaxVal = Arr[i];
                }
                Console.WriteLine(MaxVal);
            }
        }
        static void Average()
        {
            int[] NewArr = { 1, 2, 3, 4, 5, 6, 8 };
            double Avg = 0;
            int Sum = 0;
            for (int i = 0; i < NewArr.Length; i++)
            {
                Sum += NewArr[i];
            }
            Avg = Sum / NewArr.Length;
            Console.WriteLine(Avg);
        }
        static void CreateArray()
        {
            int num = 255 / 2;
            int [] ArrayY = new int[num];
            for (int i = 1; i <= 255; i+=2){
                ArrayY[i] = i;
            }
            Console.WriteLine(ArrayY);
        }
        static void GreaterThenY()
        {
            int[] NewArray = { 1, 3, 5, 7 };
            int Y = 3;
            int Count = 0;
            for (int i = 0; i < NewArray.Length; i++)
            {
                if(NewArray[i] > Y)
                {
                    Count++;
                }
                Console.WriteLine(Count);
            }
        }
        static void ArraySquare()
        {
            int[] ArrayX = { 1, 5, 10, -2 };
            for (int i = 0; i < ArrayX.Length; i++)
            {
                ArrayX[i] = ArrayX[i] * ArrayX[i];
            }
            Console.WriteLine(ArrayX);
        }

        static void NegativZero()
        {
            int[] NegArr = { 1, 5, 10, -2 };
            for (int i = 0; i < NegArr.Length; i++)
            {
                if (NegArr[i] < 0)
                {
                    NegArr[i] = 0;
                }
                Console.WriteLine(NegArr);
            }
        }
        static void MaxMinAvg()
        {
            int max = 0;
            int min = 0;
            int sum = 0;
            double avg = 0;
            int[] ThisArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < ThisArr.Length; i++)
            {
                if(ThisArr[i] > max)
                {
                    max = ThisArr[i];
                }
                if(ThisArr[i] < min)
                {
                    min = ThisArr[i];
                }
                sum += ThisArr[i];
            }
            avg = sum / ThisArr.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
        }

        static void ShiftFront()
        {
            int[] FrontArr = {1,5,10,7,-2};
            for (int i = 0; i < FrontArr.Length-1; i++)
            {
                FrontArr[i] = FrontArr[i + 1];
            }
            FrontArr[FrontArr.Length - 1] = 0;
            Console.WriteLine(FrontArr);
        }

        static void NumString()
        {
        int[] NumArr = { 1, 5, 10, -2 };
        object[] ObjArr = new object [NumArr.Length];
            for (int i = 0; i < NumArr.Length; i++)
            {
                if(NumArr[i] > 0)
                {
                    ObjArr[i] = NumArr[i];
                }
                if (NumArr[i] < 0)
                {
                    ObjArr[i] = "Dojo";
                }
                Console.WriteLine(ObjArr[i]);
            }
        }
        static void Main(string[] args)
        {
            NumString();
        }
        }
    }

