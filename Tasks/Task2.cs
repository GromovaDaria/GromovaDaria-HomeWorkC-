namespace Seminar_Tasks.Tasks {
    public static class Task2 {

        public static void Task() {
            Console.WriteLine("You are running Task 2");
            Console.WriteLine("Write two numbers to know, which number is greater and which is less");
            var FirstNumber = Console.ReadLine();
            var SecondNumber = Console.ReadLine();

            if(Int32.TryParse(FirstNumber, out var number1) && Int32.TryParse(SecondNumber, out var number2)) {
                if(number1 > number2) Console.WriteLine($"{number1} is greater then {number2}");
                else if(number1 < number2) Console.WriteLine($"{number2} is greater then {number1}");
                else Console.WriteLine($"{number1} is equal to {number2}");
            }
            
            else Console.WriteLine("Error! Inputs must be numbers!");

        }
    }
}