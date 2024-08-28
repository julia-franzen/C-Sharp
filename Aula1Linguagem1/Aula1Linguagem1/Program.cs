// See https://aka.ms/new-console-template for more information
//TRY / CATCH
try //tentar
{

    double lado1, lado2, area;

    Console.WriteLine("Digite a altura do retângulo:");
    lado1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a base do retângulo:");
    lado2 = Double.Parse(Console.ReadLine());

    area = lado1 * lado2;
    Console.WriteLine("A área do retângulo é: " + area.ToString());
    Console.ReadKey();
}

catch (Exception ex)
{
    Console.WriteLine("Erro desconhecido ocorreu. " + "\n" + ex.Message);
}
