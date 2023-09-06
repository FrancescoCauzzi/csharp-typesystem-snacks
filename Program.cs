using static System.Console;
namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Esercizio pomeridiano: Snacks");
            WriteLine();
        /*
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
        
            WriteLine("Snack 3");     
            int[] myArray = ArrayManipulator.GetArrayOfLengthTenFromUser();  
            WriteLine($"La somma degli elementi dell'array di {myArray.Length} è di {ArrayManipulator.GetSumOfElementsArray(myArray)} elementi");
            WriteLine();  
            */
            WriteLine("Snack 4");
            int[] myArray = {2,3,4,5,6,7,8,9,10};
            WriteLine($"La somma degli elementi dell'array è di {ArrayManipulator.GetSumOfElementsArray(myArray)}.");
            WriteLine($"La media degli elementi dell'array è di {ArrayManipulator.GetAverageOfElementsArray(myArray)}.");
            WriteLine();





            
             

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
                        if(int.TryParse(word, out int result))
                        {
                            WriteLine("Input non valido, inserisci una parola");
                            continue;
                        }
                        return word;
                    }
                    WriteLine("Input non valido, inserisci una parola");           
                                    
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
        internal class ArrayManipulator{

            public static int[] GetArrayOfLengthTenFromUser(){
                int[] array = new int[10];
                WriteLine("Inserisci 10 numeri, otterrai la somma dei numeri");
                for(int i = 0; i < array.Length; i++){
                    array[i] = InputGetter.GetIntInput();
                }
                return array;                            

            }
            public static int GetSumOfElementsArray(int[] array){
                int sum = 0;
                for(int i = 0; i < array.Length; i++){
                    sum += array[i];
                }
                return sum;
            }

            public static int GetAverageOfElementsArray(int[] array){
                int elementsSum = GetSumOfElementsArray(array);
                int average = elementsSum / array.Length;
                return average;
            }

                           

        }
    }

        
        
}
    
    


 