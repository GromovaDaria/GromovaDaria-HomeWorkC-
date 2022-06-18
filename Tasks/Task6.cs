namespace Seminar_Tasks.Tasks {
    public static class Task6 {
        public static void Task() {
            Console.WriteLine("You are running Task 6");
            Console.WriteLine("Write a number to know, if number is odd or even");
            var UserNumber = Console.ReadLine();

            if(Int32.TryParse(UserNumber, out var number))
            {
                if(number%2 == 0){
                    Console.WriteLine($"{number} is even");
                }
                else {
                    Console.WriteLine($"{number} is odd");
                }
            }

            else {
                Console.WriteLine("Error! Input must be a number");
            }
        }
    }
}
