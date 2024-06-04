
class Program
{
  static void Main()
  {
    var resistenza = new Resistenza();

    Console.WriteLine("Inserisci un numero intero per calcolarne la resistenza:");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
      int result = resistenza.GetResistenza(number);
      Console.WriteLine($"La resistenza è {result}");
    }
    else
    {
      Console.WriteLine("Input non valido. Inserisci un numero intero.");
    }

    Console.WriteLine($"getResistenza(39): {resistenza.GetResistenza(39)}");
    Console.WriteLine($"getResistenza(77): {resistenza.GetResistenza(77)}");
    Console.WriteLine($"getResistenza(1679): {resistenza.GetResistenza(1679)}");
    Console.WriteLine($"getResistenza(6788): {resistenza.GetResistenza(6788)}");
    Console.WriteLine($"Resistenza di sette numeri: {resistenza.SearchSevenResult()}");
  }
}

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


  /*
  Versione iterattiva
  public int GetResistenzaIterativa(int numberInput)
  {
    if (numberInput < 10)
      return 0;

    int resistenza = 0;
    while (numberInput >= 10)
    {
      int product = 1;
      while (numberInput > 0)
      {
        int cifra = numberInput % 10;
        product *= cifra;
        numberInput /= 10;
      }
      numberInput = product;
      resistenza++;
    }

    return resistenza;
  } */

  public int SearchSevenResult()
  {
    int result = 0;
    int i = 0;

    while (result != 7)
    {
      result = GetResistenza(i++);
    }

    return i;
  }
}
