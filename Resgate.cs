using System;

class Resgate
{
    public double valorPresente = 0;
    public double taxa = 0;
    public int periodo = 0;


    public double valorF()
    {
        return (valorPresente*Math.Pow((1+taxa), periodo));
    }


    public void tabela()
    {
        int counter = 1;
        double valorSaque = 0;
        int confirmador;
        do
        {
            periodo = counter;
            double rendimento = Math.Round(valorF(), 2);
            double liquido = rendimento - valorPresente;
            double saldo = rendimento - valorSaque - valorSaque;
            Console.WriteLine("[" + counter + "º mês] Valor aplicado: R$" + valorPresente + " | Taxa: " + taxa.ToString("0.00%") + " | Rendimento: R$" + rendimento.ToString("0.00") + " | Rendimento Líquido: R$" + liquido.ToString("0.00") + " | Renda Acumulada: R$" +saldo.ToString("0.00")+"");
            Console.WriteLine("Deseja efetuar um saque? ('1' para 'Sim' ou '2' para 'Não')");
            confirmador = Convert.ToInt32(Console.ReadLine());
            
            if(confirmador == 1)
            {
                Console.WriteLine("Qual o valor do saque?");
                valorSaque = Convert.ToDouble(Console.ReadLine());
                saldo = rendimento - valorSaque;
                Console.WriteLine("["+counter+"º mês] Valor aplicado: R$"+valorPresente+" | Taxa: "+taxa.ToString("0.00%")+" | Rendimento: R$"+rendimento.ToString("0.00")+" | Rendimento Líquido: R$"+liquido.ToString("0.00")+" | Renda Acumulada: R$"+saldo.ToString("0.00")+"");
            }
            counter++;
        } while (confirmador == 2);
        
    }
}






