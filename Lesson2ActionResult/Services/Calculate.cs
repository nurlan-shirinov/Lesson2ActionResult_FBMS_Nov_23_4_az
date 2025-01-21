namespace Lesson2ActionResult.Services
{
    public class Calculate : ICalculate
    {
        public decimal Data { get; set; }
        public Calculate()
        {
            
        }

        public decimal MyCalculate(decimal amount)
        {
            return Data += 100;
        }
    }
}