namespace CalcLib
{
    public class Calculator
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public int Sub()
        {
            int res;
            res = Num1 - Num2;
            return res;
        }
        public int Mul()
        {
            int res;
            res = Num1 * Num2;
            return res;
        }
        public int Div()
        {
            if (Num2 != 0)
            {

                int res = Num1 / Num2;
                return res;
            }
            else
            {
                Console.WriteLine("cannot divide by zero");
                return 0;
            }
        }
    }
}
        


