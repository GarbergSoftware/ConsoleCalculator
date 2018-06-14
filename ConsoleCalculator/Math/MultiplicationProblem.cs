namespace ConsoleCalculator.Math
{
    public class MultiplicationProblem
    {
        #region Fields
        protected int multiplicand;
        protected int multiplier;
        #endregion

        #region Constructors
        public MultiplicationProblem() { }
        public MultiplicationProblem(int multiplicand, int multiplier)
        {
            this.multiplicand = multiplicand;
            this.multiplier = multiplier;
        }
        #endregion

        #region Methods
        public virtual long Calculate()
        {
            return (long)multiplicand * (long)multiplier; //If I don't cast here, I get integer overflow
        }
        #endregion

        #region Accessors
        public int Multiplicand { get => multiplicand; set => multiplicand = value; }
        public int Multiplier { get => multiplier; set => multiplier = value; }
        #endregion
    }
}
