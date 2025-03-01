class fraudulentId{
    public void OrderId()
    {

        string [] fraudulentOrderIDs = new string[3];

        //Asignar valores a los elementos del array
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";

        Console.WriteLine($"El ID de la orden es: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"El ID de la orden es: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"El ID de la orden es: {fraudulentOrderIDs[2]}");
    }
}

