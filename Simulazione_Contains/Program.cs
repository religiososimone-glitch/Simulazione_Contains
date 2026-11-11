int i = 0, j = 0, k = 0, contenimento = 0;
string frase, pezzo;

Console.WriteLine("Inserire la frase");
frase = Console.ReadLine();
do
{
    Console.WriteLine("inserire la stringa da ricercare");
    pezzo = Console.ReadLine();
    if (pezzo.Length > frase.Length)
    {
        Console.WriteLine("non puoi ricercare qualcosa di più grande della frase iniziale");
    }
}while (pezzo.Length > frase.Length);

do
{
    char C1 = frase[k];
    char C2 = pezzo[j];
    if (C1 == C2)
    {
        k++; j++;
        contenimento++;
    }
    else
    {
        j = 0; i++; k = i;
        contenimento = 0;
    }

    if (frase.Length - i+1 <= pezzo.Length)
    {
        contenimento = -1;
    }
} while (contenimento < pezzo.Length && contenimento != -1);

if(contenimento == pezzo.Length)
{
    Console.WriteLine("La stringa è contenuta nella frase");
}
else
{
    Console.WriteLine("La stringa non è contenuta nella frase");
}

