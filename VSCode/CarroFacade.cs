// Fachada del Carro
public class CarroFacade
{
    private Motor motor;
    private SistemaCombustible sistemaCombustible;
    private SistemaElectrico sistemaElectrico;

    public CarroFacade()
    {
        motor = new Motor();
        sistemaCombustible = new SistemaCombustible();
        sistemaElectrico = new SistemaElectrico();
    }

    // Método para encender el carro
    public void EncenderCarro()
    {
        Console.WriteLine("Iniciando proceso de encendido del carro...");

        sistemaCombustible.SuministrarCombustible();
        sistemaElectrico.EncenderLuces();
        motor.Encender();

        Console.WriteLine("¡El carro está encendido y listo para usar!");
    }
     // Método para apagar el carro
    public void ApagarCarro()
    {
        Console.WriteLine("Iniciando proceso de apagado del carro...");

        motor.Apagar();
        sistemaElectrico.ApagarLuces();
        sistemaCombustible.DetenerSuministroCombustible();

        Console.WriteLine("El carro se ha apagado correctamente.");
    }
}