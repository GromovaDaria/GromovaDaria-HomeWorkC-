using Seminar_Tasks.Tasks;

namespace Seminar_Tasks {
    public static class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Choose your task (2, 4, 6 or 8)");
            var input = Console.ReadLine();

            if(Int32.TryParse(input, out var number)) {

                switch(number) {
                    case 2: 
                    Task2.Task();
                    break;
                    
                    case 4:
                    Task4.Task();
                    break;
                    
                    case 6:
                    Task6.Task();
                    break;
                    
                    case 8:
                    Task8.Task();
                    break;
                    
                    default: 
                    Console.WriteLine("There's no task with this number");
                    break;
                }
            }
            
            else {
                Console.WriteLine("Error! You should write a number");
            }
        }
    }
}