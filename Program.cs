using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digita a renda anual com salário: ");
        double rendaAnualSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite a renda anual com prestação de serviço: ");
        double rendaAnualServiço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite a renda anual com ganho de capital: ");
        double rendaAnualCapital = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite os gastos médicos: ");
        double gastosMedicos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite os gastos educacionais: ");
        double gastosEducacionais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        /*Cáculo do imposto sobre o salário*/
        double rendaMensalSalario = rendaAnualSalario / 12;
        double impostoSalario = 0;

        if (rendaMensalSalario < 3000)
        {
            impostoSalario = 0;
        }
        else if (rendaMensalSalario >= 3000 && rendaMensalSalario < 5000)
        {
            impostoSalario = rendaAnualSalario * 0.10;
        }
        else
        {
            impostoSalario = rendaAnualSalario * 0.20;
        }

        /*Cáculo de imposto sobre prestação de serviços*/
        double impostoServico = rendaAnualServiço * 0.15;

        /*Cáculo de imposto sobre ganho capital de imóveis */
        double impostoCapital = rendaAnualCapital * 0.20;

        /*Cáculo de imposto bruto */
        double impostoBruto = impostoSalario + impostoServico + impostoCapital;

        /*Cálculo abatimento*/
        double gastosMedicosEducacionais = gastosMedicos + gastosEducacionais;
        double maxAbatimento = impostoBruto * 0.30;
        double abatimento = Math.Min(gastosMedicosEducacionais, maxAbatimento);

        /*Cáculo imposto devido*/
        double impostoDevido = impostoBruto - abatimento;

        Console.WriteLine();
        /*Exibir relatório*/
        Console.WriteLine("RELATÓRIO DO IMPOSTO DO RENDA:");
        Console.WriteLine();
        Console.WriteLine("CONSOLIDADO DE RENDA");
        Console.WriteLine($"Imposto sobre salário: {impostoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Imposto sobre serviço: {impostoServico.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Imposto sobre ganho de capital: {impostoCapital.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.WriteLine();
        Console.WriteLine("DEDUÇÕES");
        Console.WriteLine($"Máximo detutível: {maxAbatimento.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Gastos dedutíveis: {gastosMedicosEducacionais.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();
        Console.WriteLine("RESUMO");
        Console.WriteLine($"Imposto bruto total: {impostoBruto.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Abatimento: {abatimento.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Imposto devido: {impostoDevido.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}