
namespace CalculatorPrivateAssemblyyy
{
    public class BasicComputation
    {
        private static float answer;

        public float addition(float num1, float num2)
        {
            answer = num1 + num2;
            return answer;
        }
        public float subtraction(float num1, float num2)
        {
            answer = num1 - num2;
            return answer;
        }
        public float multiplication(float num1, float num2)
        {
            answer = num1 * num2;
            return answer;
        }
        public float division(float num1, float num2)
        {
            answer = num1 / num2;
            return answer;
        }
    }
}
