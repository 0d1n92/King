
var res = new Resistenza();
Console.WriteLine("Inserisci un numero intero per calcololarne la resistenza");
string input = Console.ReadLine();
int number;
Int32.TryParse(input, out number);
var result = res.GetResistenza(number);
Console.WriteLine("La resistenza è " + result);
Console.WriteLine("getResistenza(39): " + res.GetResistenza(39)); 
Console.WriteLine("getResistenza(77): " + res.GetResistenza(77));
Console.WriteLine("getResistenza(1679): " + res.GetResistenza(1679)); 
Console.WriteLine("getResistenza(6788): " + res.GetResistenza(6788)); 
Console.WriteLine("Resistenza di sette numeri " + res.SearchSevenResult());



internal class Resistenza
{
     public int GetResistenza(int numberInput)
     {
         if (numberInput < 10)
             return 0;
         int product = 1;
         while (numberInput > 0)
         {
             int cifra = numberInput % 10;
             product *= cifra;
             numberInput /= 10;
         }
         return 1 + GetResistenza(product);
     } 

    public int SearchSevenResult ()
    {
        var result = 0;
        var i = 0;

        while (result != 7)
        {
            result = GetResistenza(i++);

        }

        return i;
    }

}