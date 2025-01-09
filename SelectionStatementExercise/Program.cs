namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Favsubject();
        }

        
        public static void Favsubject()
            
            {
                Console.WriteLine("What is your favorite school subject?");
                string subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "math":
                        Console.WriteLine("I don't prefer to do this!");
                        break;

                    case " science":
                        Console.WriteLine(" I love science!");
                        break;

                    case "pe":
                    case "p.e":
                    case "physical education":
                        Console.WriteLine("physical education is fun!");
                        break;
                    case "music":
                        Console.WriteLine(" I love music");
                        break;
                    case " geography":
                        Console.WriteLine(" I love geography");
                        break;
                    case "history":
                        Console.WriteLine(" history is not my favorite subject");
                        break;
                    default:
                        Console.WriteLine("I like that too");
                        break;



                }






            }
        }
    }
