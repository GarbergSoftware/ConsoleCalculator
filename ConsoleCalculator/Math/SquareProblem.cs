namespace ConsoleCalculator.Math
{
    public class SquareProblem : MultiplicationProblem
    {
        public SquareProblem(int multiplicand)
        {
            this.multiplicand = multiplicand;
        }

        new public double Calculate()
        {
            return System.Math.Pow(multiplicand, 2);
        }
    }
}