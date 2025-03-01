/*Escritrua de codigo que genera 3 numeros aleatorios
  y los muestra en salida.*/


public class TiradaDados{
  public void tiradaDados()
  {

    Random tirada = new Random();

    int tirada1 = tirada.Next(1, 7);
    int tirada2 = tirada.Next(1, 7);
    int tirada3 = tirada.Next(1, 7);

    

    int total = tirada1 + tirada2 + tirada3;

    if ((tirada1 == tirada2) || (tirada2 == tirada3) || (tirada1 == tirada3))
    {
      Console.WriteLine("¡Sacaste doble! ¡+2 de bonificación al total!");
      total += 2;
    }  


    if (total >= 15)
    {
      Console.WriteLine("Has ganado!");
    }
    if (total < 15)
    {
      Console.WriteLine("Has Perdido!");
    }

    Console.WriteLine($"Tirada de dados: {tirada1} + {tirada2} + {tirada3} = {total}");

  }
}
