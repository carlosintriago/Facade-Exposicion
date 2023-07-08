using System;
public class Program
{
    public static void Main(string[] args)
    {
        CarroFacade carroFacade = new CarroFacade();

        // Encender el carro
        carroFacade.EncenderCarro();

        Console.WriteLine();

        // Apagar el carro
        carroFacade.ApagarCarro();
    }
}