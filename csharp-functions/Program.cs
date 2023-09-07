/*Stampare l’array di numeri fornito a video*/

int[] array = { 2, 6, 7, 5, 3, 9 };
Console.Write("Array originale ");
PrintArray(array);


/*Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale 
	* non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])*/

int[] arraySquare = SquareArray(array);
Console.Write("Array al quadrato ");
PrintArray(arraySquare);
Console.Write("Array originale ");
PrintArray(array);

/*Stampare la somma di tutti i numeri*/


int sum = SumArrayElement(array);
Console.WriteLine($"Somma dei numeri {sum}");

/*Stampare la somma di tutti i numeri elevati al quadrati*/

int squareSum = SquareNumber(sum);
Console.WriteLine($"Somma dei numeri elevati al quadrato {squareSum}");

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

