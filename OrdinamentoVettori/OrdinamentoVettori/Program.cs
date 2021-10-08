using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //creazione e inizializzazione di un vettore di interi
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //richiamo metodo per l'ordinamento
            ordina(vettore);

            //stampo a video il contenuto del vettore
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);
            
            //evito che l'interfaccia console si chiuda
            Console.ReadKey();
        }

        static void ordina (int[] vettore)
        {
            //.Sort: metodo di riordinamento degli array
            Array.Sort(vettore);
        }

     
    }
}
