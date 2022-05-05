namespace Solution
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2) =>
          (operation == '+') ? value1 + value2 :
          (operation == '-') ? value1 - value2 :
          (operation == '*') ? value1 * value2 :
          (operation == '/') ? value1 / value2 :
          0;
    }
}