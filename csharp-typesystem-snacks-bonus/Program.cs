using static System.Console;
namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Esercizio pomeridiano: Snacks");
            WriteLine();
            bool guard = true;
            while (guard)
            {
                WriteLine("Inserisci un numero da 1 a 10 per visualizzare il corrispondente snack");
                int snackNumber = InputGetter.GetIntInput();
                Snacks.ShowASnack(snackNumber);
                WriteLine();
                WriteLine("Vuoi visualizzare un altro snack? (si/no)");
                string answer = InputGetter.GetStringInput();
                if (answer.ToLower() == "no")
                {
                    guard = false;
                }
            }
        }

        internal class Snacks
        {

            public static void ShowASnack(int SnackNumber)
            {
                switch (SnackNumber)
                {
                    case 1:
                        Snack1();
                        break;
                    case 2:
                        Snack2();
                        break;
                    case 3:
                        Snack3();
                        break;
                    case 4:
                        Snack4();
                        break;
                    case 5:
                        Snack5();
                        break;
                    case 6:
                        Snack6();
                        break;
                    case 7:
                        Snack7();
                        break;
                    case 8:
                        Snack8();
                        break;
                    case 9:
                        Snack9();
                        break;
                    case 10:
                        Snack10();
                        break;
                    default:
                        WriteLine("Il numero inserito non è valido");
                        break;

                }

            }
            public static void Snack1()
            {
                WriteLine("Snack 1");
                WriteLine("L’utente inserisce due numeri in successione. Il software stampa il maggiore.");
                WriteLine("Inserisci due numeri interi");
                int a = InputGetter.GetIntInput();
                int b = InputGetter.GetIntInput();
                IntManipulator.PrintBiggerInt(a, b);
                WriteLine();
            }

            public static void Snack2()
            {
                WriteLine("Snack 2");
                WriteLine("L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.");
                WriteLine("Inserisci due parole");
                string word1 = InputGetter.GetStringInput();
                string word2 = InputGetter.GetStringInput();
                StringManipulator.PrintLogestWordOrDraw(word1, word2);
                WriteLine();
            }
            public static void Snack3()
            {
                WriteLine("Snack 3");
                WriteLine("Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.");
                int[] snack3Array = IntArrayManipulator.GetArrayOfSpecifiedLengthFromUser(10);
                WriteLine($"La somma degli elementi dell'array di {snack3Array.Length} è di {IntArrayManipulator.GetSumOfElementsArray(snack3Array)}");
                WriteLine();
            }

            public static void Snack4()
            {
                WriteLine("Snack 4");
                WriteLine("Calcola la somma e la media dei numeri da 2 a 10.");
                int[] snack4Array = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                WriteLine("L'array iniziale è stato creato con i seguenti elementi:");
                ArrayPrinter.PrintArray(snack4Array);
                WriteLine($"La somma degli elementi dell'array è {IntArrayManipulator.GetSumOfElementsArray(snack4Array)}.");
                WriteLine($"La media degli elementi dell'array è {IntArrayManipulator.GetAverageOfElementsArray(snack4Array)}.");
                WriteLine();
            }

            public static void Snack5()
            {
                WriteLine("Snack 5");
                WriteLine(" Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");
                WriteLine("Inserisci un numero intero");
                int Snack5Number = InputGetter.GetIntInput();
                IntManipulator.PrintEvenOrOdd(Snack5Number);
                WriteLine();
            }

            public static void Snack6()
            {
                WriteLine("Snack 6");
                WriteLine("In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.");
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
            }

            public static void Snack7()
            {
                WriteLine("Snack 7");
                WriteLine("Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.");
                int[] Snack7Array = IntArrayManipulator.GetArrayOfSpecifiedLengthFromUserOnlyOddNumbers(6);
                ArrayPrinter.PrintArray(Snack7Array);
                WriteLine();
            }

            public static void Snack8()
            {
                WriteLine("Snack 8");
                WriteLine("Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.");
                int[] snack8Array = { 1, 3, 5, 6 };
                WriteLine("L'array iniziale è stato creato con i seguenti elementi:");
                ArrayPrinter.PrintArray(snack8Array);
                WriteLine($"La somma degli elementi in posizione dispari è {IntArrayManipulator.GetSumOfElementsArrayInOddPosition(snack8Array)}");
                WriteLine();
            }

            public static void Snack9()
            {
                WriteLine("Snack 9");
                WriteLine("Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.");
                int[] snack9Array = new int[12];
                // ArrayPrinter.PrintArray(snack9Array);
                IntArrayManipulator.ModifyIntArrayUntilSumOfAllElementsIsLessThan50(snack9Array);
                ArrayPrinter.PrintArray(snack9Array);
                WriteLine();
            }

            public static void Snack10()
            {
                WriteLine("Snack 10");
                WriteLine("Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.");
                WriteLine("Digita la quantità di array che vuoi generare");
                int numberOfArrays = InputGetter.GetIntInput();
                for (int i = 0; i < numberOfArrays; i++)
                {
                    int[] array = IntArrayManipulator.GenerateAnArrayOfRandomNumbers(10);
                    ArrayPrinter.PrintArray(array);
                    WriteLine();
                }

            }
        }

        internal class InputGetter
        {
            public static int GetIntInput()
            {
                while (true)
                {

                    if (int.TryParse(ReadLine(), out int result))
                    {
                        return result;
                    }
                    WriteLine("Input non valido. Iserisci un numero intero.");
                }
            }

            public static string GetStringInput()
            {
                while (true)
                {
                    //WriteLine("Inserisci una parola");
                    string? word = ReadLine();
                    if (!string.IsNullOrEmpty(word))
                    {
                        if (int.TryParse(word, out int result))
                        {
                            WriteLine("Input non valido, inserisci una stringa");
                            continue;
                        }
                        return word;
                    }
                    WriteLine("Input non valido, inserisci una stringa");

                }
            }
        }

        internal class IntManipulator
        {
            public static void PrintBiggerInt(int a, int b)
            {
                if (a > b)
                {
                    WriteLine($"Il numero pià grande tra i due è {a}");

                }
                else if (a == b)
                {
                    WriteLine("I numeri sono uguali");

                }
                else
                {
                    WriteLine($"Il numero più grande tra i due è {b}");
                }
            }

            public static void PrintEvenOrOdd(int number)
            {
                if (number % 2 == 0)
                {
                    WriteLine("Il numero da te inserito é pari");
                    WriteLine(number);
                }
                else
                {
                    WriteLine("Il numero da te inserito é dispari");

                    WriteLine(number + 1);
                }
            }
        }

        internal class StringManipulator
        {
            public static void PrintLogestWordOrDraw(string word1, string word2)
            {
                if (word1.Length > word2.Length)
                {
                    WriteLine($"La parola più lunga è '{word1}'");
                    WriteLine($"La parola più corta è '{word2}'");

                }
                else if (word1.Length == word2.Length)
                {
                    WriteLine("Le parole hanno la stessa lunghezza");

                }
                else
                {
                    WriteLine($"La parola pià lunga é '{word2}'");
                    WriteLine($"La parola più corta è '{word1}'");


                }
            }
        }
        internal class IntArrayManipulator
        {

            public static int[] GetArrayOfSpecifiedLengthFromUser(int length)
            {
                int[] array = new int[length];
                WriteLine($"Inserisci {length} numeri");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = InputGetter.GetIntInput();
                }
                return array;
            }
            public static int GetSumOfElementsArray(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }

            public static float GetAverageOfElementsArray(int[] array)
            {
                int elementsSum = GetSumOfElementsArray(array);
                float average = (float)elementsSum / (float)array.Length;
                return average;
            }
            public static int[] GetArrayOfSpecifiedLengthFromUserOnlyOddNumbers(int length)
            {
                int[] array = new int[length];
                WriteLine($"Inserisci {length} numeri");

                for (int i = 0; i < length; i++)
                {
                    int userInput = InputGetter.GetIntInput();
                    if (userInput % 2 != 0)
                    {
                        array[i] = userInput;

                    }
                }

                return array;
            }
            // snacck 8  
            public static int GetSumOfElementsArrayInOddPosition(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i += 2)
                {

                    sum += array[i];
                }
                return sum;
            }

            public static int[] ModifyIntArrayUntilSumOfAllElementsIsLessThan50(int[] array)
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (sum > 50)
                    {
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

            public static int[] GenerateAnArrayOfRandomNumbers(int length)
            {
                int[] array = new int[length];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 100);
                }
                return array;
            }
        }
        internal class StringArrayManipulator
        {

        }
        internal class ArrayPrinter
        {
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




