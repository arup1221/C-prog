using System; 
 
class SimpleCalculator {

  static void Main(string[] args) {
    Console.WriteLine("Simple Arithmetic Calculator");
    Console.WriteLine("Support Operation: + - * / %");
    Console.WriteLine("Enter Operand: ");

    char Operation = Console.ReadKey().KeyChar;
    Console.WriteLine();
    Console.WriteLine("Enter Operand: ");

    double operand1 = Convert.ToDouble(Console.ReadLine());  
    Console.WriteLine("Enter Operand: ");

    double operand2 = Convert.ToDouble(Console.ReadLine());
    double result = 0;

    switch (Operation) {
    case '+':
      result = operand1 + operand2;
      break;
    case '-':
      result = operand1 - operand2;
      break;
    case '*':
      result = operand1 * operand2;
      break;
    case '/':
      if(operand2 != 0){
        result = operand1 / operand2;
      }
      else
      {
        Console.WriteLine("Divide by zero error");
        return;
      }
      break;

    case '%':
      if(operand2 != 0){
        result = operand1 % operand2;
      }
      else{
        Console.WriteLine("Error Modular by Zero is not allowed");
        return;
      }
      break;
    default:
      Console.WriteLine("Error Invalid Operation");
      return;
      }

      Console.WriteLine(operand1+" " + Operation+" " + operand2+" " + "Result = " + result);
      }
  }
