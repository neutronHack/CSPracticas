/*Escritrua de codigo que genera 3 numeros aleatorios
  y los muestra en salida.*/


using System.Security.Cryptography.X509Certificates;

public class TiradaDados{
  public void tiradaDados()
  {

    Random tirada = new Random();

    int tirada1 = tirada.Next(1, 7);
    int tirada2 = tirada.Next(1, 7);
    int tirada3 = tirada.Next(1, 7);

    

    int total = tirada1 + tirada2 + tirada3;

    Console.WriteLine($"Tirada de dados: {tirada1} + {tirada2} + {tirada3} = {total}");

    if ((tirada1 == tirada2) || (tirada2 == tirada3) || (tirada1 == tirada3))
    {
     
      if ((tirada1 == tirada2) && (tirada2 == tirada3))
      {
        Console.WriteLine("¡Sacaste triples! ¡+6 de bonificación al total!");
        total += 6;
      }
      else
      {
        Console.WriteLine("¡Sacaste doble! ¡+2 de bonificación al total!");
        total += 2;
    }

      Console.WriteLine($"Su total incluyendo el bono: {total}");  

    }
    if (total >= 16) 
    {
      Console.WriteLine("¡Ganas un nuevo carro!");
    } 
    else if (total >= 10)
    {
      Console.WriteLine("¡Ganas un nuevo portátil!");
    }
    else if (total == 7)
    {
      Console.WriteLine("¡has ganado un viaje para 2 personas!");
    }
    else
    {
      Console.WriteLine("Has ganado una cocina!");
    }
      
    }
  }




      