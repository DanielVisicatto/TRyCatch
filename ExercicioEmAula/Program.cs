int valor;
bool repete;

do
{
    Console.WriteLine("Informe um valor inteiro...");
    try
    {
        valor = int.Parse(Console.ReadLine());
        repete = false;
    }
    catch (Exception e)
    {
        Console.WriteLine("Por favor, informe um valor inteiro\n" +
            $"{e.Message}");
        repete = true;
        Console.Clear();
    }    
}
while (repete);
