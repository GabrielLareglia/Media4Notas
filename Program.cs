double n1, n2, n3, n4,media;
string resultadofinal;
Console.WriteLine();

Console.WriteLine("--- Média ---");
Console.WriteLine();

Console.WriteLine("Digite as suas notas abaixo.");

Console.WriteLine("Nota1\n");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota2\n");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota3\n");
n3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nota4\n");
n4 = Convert.ToDouble(Console.ReadLine());


if (n1 < 0 || n1 > 10
 || n2 < 0 || n2 > 10
 || n3 < 0 || n3 > 10
 || n4 < 0 || n4 > 10)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}
else
{
    media = (n1 + n2 + n3 + n4) / 4;

    if (media < 5)
    {
        resultadofinal= "Reprovado";
    }
    else if (media > 6)
    {
        resultadofinal= "Aprovado";
    }
    else
    {
        resultadofinal= "Em recuperação";
    }

    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultadofinal}");
}

