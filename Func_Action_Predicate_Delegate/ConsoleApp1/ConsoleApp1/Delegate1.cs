
namespace ConsoleApp1
{
    internal class Delegate1
    {
        private Func<int, float, double, double> addNums1;

        public Delegate1(Func<int, float, double, double> addNums1)
        {
            this.addNums1 = addNums1;
        }
    }
}