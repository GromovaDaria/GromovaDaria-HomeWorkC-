namespace Seminar_Tasks.Tasks {
    public static class Task4 {
        public static void Task() {
            Console.WriteLine("You are running Task 4");
            Console.WriteLine("Write three numbers to know, which number is greater");
            var FirstNumber = Console.ReadLine();
            var SecondNumber = Console.ReadLine();
            var ThirdNumber = Console.ReadLine();

            if(Int32.TryParse(FirstNumber, out var number1) && Int32.TryParse(SecondNumber, out var number2) && Int32.TryParse(ThirdNumber, out var number3)) {
                List < int > list = new List < int > { number1, number2, number3 };

                var highest = list[0];
                for(var i = 1;i < list.Count;++i) {
                    if(list[i] > highest) {
                        highest = list[i]; 
                    }
                }

                Console.WriteLine($"{highest} is the greater number");
            }

            else {
                Console.WriteLine("Error! All inputs must be a number");
            }
        }
    }
}
