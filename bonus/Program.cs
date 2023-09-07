/*BONUS
 * Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi 
 * di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. 
 * A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono 
 * inseriti a mano dall’utente esternamente.
Rieseguire il programma con l’input preso esternamente dall’utente.*/

Console.WriteLine("Scegli un numero");
   
bool success = int.TryParse(Console.ReadLine(), out int userNumber);

if (success == true)
{
    int[] userNumbersArray = new int[userNumber];

    for (int i = 0; i < userNumbersArray.Length; i++)
    {
        Console.WriteLine($"Scegli il {i + 1} numero");
        bool successNumber = int.TryParse(Console.ReadLine(), out int selectedNumbers);
        if (successNumber == true)
        {
            userNumbersArray[i] = selectedNumbers;
        }
    }

    Console.Write("Array originale ");
    PrintArray(userNumbersArray);

    int[] arraySquare = SquareArray(userNumbersArray);
    Console.Write("Array al quadrato ");
    PrintArray(arraySquare);
    Console.Write("Array originale ");
    PrintArray(userNumbersArray);

    int sum = SumArrayElement(userNumbersArray);
    Console.WriteLine($"Somma dei numeri {sum}");

    int squareSum = SquareNumber(sum);
    Console.WriteLine($"Somma dei numeri elevati al quadrato {squareSum}");

}



//FUNZIONI

/* Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma 
“[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina */

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }

    Console.WriteLine("]");

}

/* int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.*/

int SquareNumber(int n)
{
    return n * n;
}


/* int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi 
 * elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! 
 * Vi ricordate perchè? Pensateci (vedi slide) */
int[] SquareArray(int[] array)
{
    int[] arrayClone = (int[])array.Clone();

    for (int i = 0; i < arrayClone.Length; i++)
    {
        arrayClone[i] = arrayClone[i] * arrayClone[i];
    }

    return arrayClone;
}


/* int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi 
 * dell’array. */

int SumArrayElement(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}
