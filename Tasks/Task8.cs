namespace Seminar_Tasks.Tasks {
    public static class Task8 {

        public static void Task() {
            Console.WriteLine("You are running Task 8");
            Console.WriteLine("Write a number to know even numbers from 1 to your number");
            var UserNumber = Console.ReadLine();

            if(Int32.TryParse(UserNumber, out var number)) {
                if (number <= 0) Console.WriteLine("Number must be higher than 0");
                else if(number == 1) Console.WriteLine("There is no even numbers between 1");
                else {
                    Console.WriteLine("These numbers are even: ");
                    for (var i = 2; i <= number; i++) {
                        if(i%2 == 0){
                           Console.WriteLine(i); 
                        }
                    }
                }
            }
            else {
                Console.WriteLine("Error! Input must be a number");
                 
            }
        }
    }
}