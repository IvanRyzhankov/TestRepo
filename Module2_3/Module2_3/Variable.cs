namespace Module2_3
{
    public class Variable
    {
        public double VariableA { get; private set; }
        public double VariableB { get; private set; }
        public Variable(double firstVariable, double secondVariable)
        {
            VariableA = firstVariable;
            VariableB = secondVariable;
        }

        public void SwapValues()
        {
            VariableA = VariableA + VariableB;
            VariableB = VariableA - VariableB;
            VariableA = VariableA - VariableB;
        }
    }
}