
class Program
{
    static int GetMaxFrequente(int[] array)
    {
       
        var query = Query(array);
        
        return query.First().Numero;
    }

    private static (int Numero, int Frequenza)[] Query(int[] array)
    {
        var frequenzaQuery = array
            .GroupBy(numero => numero)
            .Select(gruppo => (Numero: gruppo.Key, Frequenza: gruppo.Count()))
            .OrderByDescending(obj => obj.Frequenza)
            .ThenBy(obj => obj.Numero)
            .ToArray();

        return frequenzaQuery;
    }
    static int[] GetMaxFrequenti(int[] array, int k)
    {
        return Query(array).Select(risultato => risultato.Numero).Take(k).ToArray();
    }


    static void Main()
    {
        int[] numeri1 = { 55, 42, 88, 42, 88, 42 };
        int[] numeri2 = { 1, 52, 52, 1, 56, 1, 54, 54, 1, 54 };
        int[] numeri3 = { 52, 52, 52, 56, 54, 54, 54 };

        Console.WriteLine($"getMaxFrequente([55, 42, 88, 42, 88, 42]): {GetMaxFrequente(numeri1)}");
        Console.WriteLine($"getMaxFrequente([1, 52, 52, 1, 56, 1, 54, 54, 1, 54]): {GetMaxFrequente(numeri2)}");
        Console.WriteLine($"getMaxFrequente([52, 52, 52, 56, 54, 54, 54]): {GetMaxFrequente(numeri3)}");

        int[] numeri4 = { 1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54 };
        int[] numeri5 = { 1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54 };
        int[] numeri6= { 1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54 };

        Console.WriteLine($"getMaxFrequenti([1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54], 1): [{string.Join(", ", GetMaxFrequenti(numeri4,1))}]");
        Console.WriteLine($"getMaxFrequenti([1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54], 2): [{string.Join(", ", GetMaxFrequenti(numeri5,2))}]");
        Console.WriteLine($"getMaxFrequenti([1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54], 3): [{string.Join(", ", GetMaxFrequenti(numeri6,3))}]");

    }
}
