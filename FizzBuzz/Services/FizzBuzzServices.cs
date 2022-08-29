using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public static class FizzBuzzServices
    {
        public static FizzBuzzModel GetFizzBuzzService()
        {
            FizzBuzzModel model = new();

            model.FizzValue = 3;
            model.BuzzValue = 5;
            return model;
        }

        public static void PostFizzBuzzService(FizzBuzzModel fizzBuzz)
        {
            List<string> fbItems = new();

            bool isFizz;
            bool isBuzz;

            for (var i = 1; i <= 300; i++)
            {
                isFizz = (i % fizzBuzz.FizzValue == 0);
                isBuzz = (i % fizzBuzz.BuzzValue == 0);

                if (isFizz && isBuzz)
                {
                    fbItems.Add("FizzBuzz");

                }
                else if (isFizz)
                {
                    fbItems.Add("Fizz");
                }
                else if (isBuzz)
                {
                    fbItems.Add("Buzz");
                }
                else
                {
                    fbItems.Add(i.ToString());
                }
            }

            fizzBuzz.Result = fbItems;
        }
    }
}
