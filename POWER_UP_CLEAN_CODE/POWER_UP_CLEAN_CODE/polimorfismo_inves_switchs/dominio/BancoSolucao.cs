namespace POWER_UP_CLEAN_CODE.polimorfismo_inves_switchs.dominio
{
    public abstract class ClienteBaseSolucao
    {
        public double Valor { get; set; }

        //Solução
        public abstract double AplicarJurosSobreValor();
    }

    public class ClientePrataSolucao : ClienteBaseSolucao
    {
        public double Juros
        {
            get { return 0.5; }
        }

        public override double AplicarJurosSobreValor()
        {
            return Valor * Juros;
        }
    }

    public class ClienteOuroSolucao : ClienteBaseSolucao
    {
        public double Juros
        {
            get { return 0.5; }
        }
        
        public override double AplicarJurosSobreValor()
        {
            return Valor * Juros / 2;
        }
    }

    public class ClienteVipSolucao : ClienteBaseSolucao
    {
        public double Juros
        {
            get { return 0.2; }
        }
        
        public override double AplicarJurosSobreValor()
        {
            return Valor * Juros;
        }
    }
    public class BancoSolucao
    {
        public double PegarEmprestimo(ClienteBaseSolucao cliente)
        {
            return cliente.AplicarJurosSobreValor();
        }
    }
}