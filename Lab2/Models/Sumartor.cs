namespace Lab2.Models
{
    internal class Sumartor(int[] num)
    {
        private int[] numbers = num;

        public int Sum() { return numbers.Sum(); }
         public double SumDiv3() { return numbers.Where(x => x % 3 == 0).Sum(); }

        public int Count() { return numbers.Count(); }
        public void Display(int low, int high) { 
            if(low < 0)
                low = 0;
            if(high > numbers.Length - 1)
                high = numbers.Length - 1;
          
            for(int i = low; i <= high; i++)
            {
                Console.WriteLine(numbers[i]);
            }   
        }
    }
}
