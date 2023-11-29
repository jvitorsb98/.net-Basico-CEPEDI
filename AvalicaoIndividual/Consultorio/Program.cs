class Program
{
    static void Main()
    {
        try
        {
            Medico medico = new Medico("Dr. João", new DateTime(1980, 1, 1), "1234567890", "CRM12345");
            Paciente paciente = new Paciente("Maria", new DateTime(1995, 5, 15), "98765432109", "masculino", "Dor de cabeça, febre");
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"Erro: {e.Message}");
        }
    }
}
