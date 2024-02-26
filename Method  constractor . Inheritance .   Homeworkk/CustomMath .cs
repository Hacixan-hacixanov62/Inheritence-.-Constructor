

namespace Method__constractor_._Inheritance_.___Homeworkk

{
    class CustomMath
    {
        public int SumOFNumber(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public string ResultOfNumber (int a)
        {
            if (a%2==0)
            {
                return "Cutdur";


            }
            else
            {
                return "Tekdir";

            }
            
        }


        public int CountofNumber(int[] array)
        { 
            int sum = 0;

            foreach (int i in array)
            {
                if (i%2==0)
                {
                    sum += i;
                }
           
                
            }
            int result = sum * sum;

            return result;
        }

        public int FindOfNumber(int n)
        {
            int result = 1;

            for (int i = 1;i < n; i++)
            {
                result *= i;
            }
            return result;
           
            
            
        }



    }

   

}



