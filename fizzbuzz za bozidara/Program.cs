namespace fizzbuzz_za_bozidara
{
    internal class Program
    {
        public static List<int> NapraviListu()
        {
            var intList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                intList.Add(i+1);
            }
            return intList;
        }

        static void Obrada(List<int> obradnaLista)
        {
            

            for (int i = 0; i < 100; i++)
            {

                //moglo je i sa switchom al ne bi bilo neke razlike
                //ako zelis uradicu je sa switchom
                if (obradnaLista[i] % 3 == 0 && obradnaLista[i] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz" + " ");
                }
                else if (obradnaLista[i] % 3 == 0)
                {
                    Console.Write("Fizz" + " ");
                }
                else if (obradnaLista[i] % 5 == 0)
                {
                    Console.Write("Buzz" + " \n");
                }
                else
                {
                    Console.Write(obradnaLista[i] + " ");
                }
                // nova linija je namestena na svaki FizzBuzz , tako mi je izgledalo najfinije
                // ako zelis da ga drukcije uredim samo reci
            }
        }

        static void Main(string[] args)
        {
            //malo sam iscepkao u metode cisto radi urednijeg koda , trudim se da budem sto uredniji
            
            List<int> obradnaLista = NapraviListu();

            Obrada(obradnaLista);
        }

        
    }
}