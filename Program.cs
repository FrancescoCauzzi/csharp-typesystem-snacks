using static System.Console;
namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Esercizio pomeridiano: Snacks");
            WriteLine();

            WriteLine("Snack 1");            
            int a = InputGetter.GetIntInput();
            int b = InputGetter.GetIntInput();
            IntManipulator.PrintBiggerInt(a,b);
            WriteLine();

            WriteLine("Snack 2");  
            string word1 = InputGetter.GetStringInput();
            string word2 = InputGetter.GetStringInput();
            StringManipulator.PrintLogestWordOrDraw(word1,word2);
            WriteLine();          

        }
    }
    internal class InputGetter{
        public static int GetIntInput(){
            while (true)
            {
                WriteLine("Inserisci un numero intero");
                if (int.TryParse(ReadLine(), out int result))
                {
                    return result;
                }
                WriteLine("Invalid input. Please enter an integer.");
            }  
        }

        public static string GetStringInput(){
            while (true)
            {
                WriteLine("Inserisci una parola");
                string? word = ReadLine();
                if (!string.IsNullOrEmpty(word))
                {
                    return word;
                }
                WriteLine("Invalid input. Please enter a string.");           
                                  
            }
        }
    }    

    internal class IntManipulator{
        public static void PrintBiggerInt(int a, int b){
            if(a > b){
                WriteLine($"Il numero pià grande tra i due è {a}");}
            else if(a == b){
                WriteLine("I numeri sono uguali");                      
            }else{
                WriteLine($"Il numero più grande tra i due è {b}");
            }
        }        
    }

    internal class StringManipulator{
        public static void PrintLogestWordOrDraw(string word1, string word2){
            if(word1.Length > word2.Length){
                WriteLine($"La parola pià lunga è '{word1}'");
            }else if(word1.Length == word2.Length){
                WriteLine("Le parole hanno la stessa lunghezza");
            
            }else{
                WriteLine($"La parola pià lunga é '{word2}'");        
                
            }        
       }
    }
    
}
 