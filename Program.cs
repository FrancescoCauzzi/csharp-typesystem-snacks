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
            WriteLine("Inserisci due numeri interi");            
            int a = InputGetter.GetIntInput();
            int b = InputGetter.GetIntInput();
            IntManipulator.PrintBiggerInt(a,b);
            WriteLine();

            WriteLine("Snack 2");  
            WriteLine("Inserisci due parole");          
            string word1 = InputGetter.GetStringInput();
            string word2 = InputGetter.GetStringInput();
            StringManipulator.PrintLogestWordOrDraw(word1,word2);
            WriteLine();  
        
            WriteLine("Snack 3");     
            int[] snack3Array = IntArrayManipulator.GetArrayOfSpecifiedLengthFromUser(10);  
            WriteLine($"La somma degli elementi dell'array di {snack3Array.Length} è di {IntArrayManipulator.GetSumOfElementsArray(snack3Array)} elementi");
            WriteLine();  
            
            WriteLine("Snack 4");
            int[] snack4Array = {2,3,4,5,6,7,8,9,10};
            WriteLine("L'array iniziale è stato creato con i seguenti elementi:");
            ArrayPrinter.PrintArray(snack4Array);
            WriteLine($"La somma degli elementi dell'array è di {IntArrayManipulator.GetSumOfElementsArray(snack4Array)}.");
            WriteLine($"La media degli elementi dell'array è di {IntArrayManipulator.GetAverageOfElementsArray(snack4Array)}.");
            WriteLine();
            
            WriteLine("Snack 5");
            WriteLine("Inserisci un numero intero");
            int Snack5Number = InputGetter.GetIntInput();
            IntManipulator.PrintEvenOrOdd(Snack5Number);
            WriteLine();
            
            WriteLine("Snack 6");
            string[] guestNames = {
                "Nick Carraway",
                "Jordan Baker",
                "Tom Buchanan",
                "Daisy Buchanan",
                "Myrtle Wilson",                
                "Meyer Wolfsheim",
                "Klipspringer",
                "George Wilson",
                "Catherine",
                "Lucille",
                "Chester McKee",
                "Owl Eyes"
            };
            WriteLine("Inserisci il tuo nome e vediamo se puoi entrare");
            string userName = InputGetter.GetStringInput();
            WriteLine(guestNames.Contains(userName) ? $"{userName} sei nella lista degli invitati alla festa" : $"{userName}, non sei nella lista dei invitati");
            WriteLine();
            
            WriteLine("Snack 7");
            int[] Snack7Array = IntArrayManipulator.GetArrayOfSpecifiedLengthFromUserOnlyOddNumbers(6);
            ArrayPrinter.PrintArray(Snack7Array);
            WriteLine();
            
            WriteLine("Snack 8");
            int[] snack8Array = {1,3,5,6};  
            WriteLine("L'array iniziale è stato creato con i seguenti elementi:");
            ArrayPrinter.PrintArray(snack8Array);          
            WriteLine($"La somma degli elementi in posizione dispari è {IntArrayManipulator.GetSumOfElementsArrayInOddPosition(snack8Array)}");
            WriteLine();
            
            WriteLine("Snack 9");                       
            int[] snack9Array = new int[12];
            // ArrayPrinter.PrintArray(snack9Array);
            IntArrayManipulator.ModifyIntArrayUntilSumOfAllElementsIsLessThan50(snack9Array);
            ArrayPrinter.PrintArray(snack9Array);
            WriteLine();
            
            WriteLine("Snack 10");            
            WriteLine("Digita la quantità di array che vuoi generare");
            int numberOfArrays = InputGetter.GetIntInput();
            for (int i = 0; i < numberOfArrays; i++)
            {
                int[] array = IntArrayManipulator.GenerateAnArrayOfRandomNumbers(10);
                ArrayPrinter.PrintArray(array);
                WriteLine();            
            }
        }                
                
        internal class InputGetter{
            public static int GetIntInput(){
                while (true)
                {
                    
                    if (int.TryParse(ReadLine(), out int result))
                    {
                        return result;
                    }
                    WriteLine("Input non valido. Iserisci un numero intero.");
                }  
            }

            public static string GetStringInput(){
                while (true)
                {
                    //WriteLine("Inserisci una parola");
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

            public static void PrintEvenOrOdd(int number){
                if(number % 2 == 0){
                    WriteLine("Il numero da te inserito é pari");                
                    WriteLine(number);
                }else{
                    WriteLine("Il numero da te inserito é dispari");                

                    WriteLine(number + 1);
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
        internal class IntArrayManipulator{

            public static int[] GetArrayOfSpecifiedLengthFromUser(int length){
                int[] array = new int[length];
                WriteLine($"Inserisci {length} numeri");
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

            public static float GetAverageOfElementsArray(int[] array){
                int elementsSum = GetSumOfElementsArray(array);
                float average = (float)elementsSum / (float)array.Length;
                return average;
            }
            public static int[] GetArrayOfSpecifiedLengthFromUserOnlyOddNumbers(int length){
                int[] array = new int[length];
                WriteLine($"Inserisci {length} numeri dispari");
                int counter = 0;
                while(counter < array.Length){
                    int userInput = InputGetter.GetIntInput();
                    if(userInput % 2 != 0){
                        array[counter] = userInput;
                        counter++;                    
                    }else{
                        WriteLine("Inserisci un numero dispari");
                    
                    }
               }                               
                return array;                          
            }  
            // snacck 8  
            public static int GetSumOfElementsArrayInOddPosition(int[] array){
                int sum = 0;
                for(int i = 0; i < array.Length; i++){
                    if(i % 2 == 0){
                        sum += array[i];
                    }
                }
                return sum;            
            }     

            public static int[] ModifyIntArrayUntilSumOfAllElementsIsLessThan50(int[] array){
                int sum = 0;
                
                for(int i = 0; i < array.Length; i++){
                    if(sum > 50){
                        WriteLine("La somma degli elementi è maggiore di 50, non posso procedere");
                        return array;
                    }
                    WriteLine("Inserisci un numero");
                    int userInput = InputGetter.GetIntInput();
                    array[i] = userInput;
                    sum += userInput;
                }                                  
                return array;            
            }

            public static int[] GenerateAnArrayOfRandomNumbers(int length){
                int[] array = new int[length];
                Random random = new Random();
                for(int i = 0; i < array.Length; i++){
                    array[i] = random.Next(0, 100);
                }
                return array;            
            }
        }
        internal class StringArrayManipulator{

        }        
        internal class ArrayPrinter{
            public static void PrintArray(Array array)
            {
                Write("Il tuo array è: ");
                if (array is int[])
                {
                    WriteLine(string.Join(", ", (int[])array));
                }
                else if (array is string[])
                {
                    WriteLine(string.Join(", ", (string[])array));
                }                
                else
                {
                    WriteLine("Tipo di array non supportato");
                }
            }
        }
    }

        
        
}
    
    


 