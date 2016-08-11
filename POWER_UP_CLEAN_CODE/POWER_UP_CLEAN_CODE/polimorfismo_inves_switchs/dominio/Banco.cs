using System;

namespace POWER_UP_CLEAN_CODE.polimorfismo_inves_switchs.dominio
{
    public abstract class ClienteBase
    {
        public double Valor { get; set; }
    }
    
    public class ClientePrata : ClienteBase
    {
        public double Juros { get; set; }
        
    }

    public class ClienteOuro : ClienteBase
    {
        public double Juros { get; set; }
    }

    public class ClienteVip : ClienteBase
    {
        public double Juros { get; set; }
    }

    public class Banco
    {
        public double PegarEmprestimo(ClienteBase cliente)
        {
            if (cliente.GetType() == typeof(ClientePrata))
                return cliente.Valor * ((ClientePrata)cliente).Juros;

            if (cliente.GetType() == typeof(ClienteOuro))
                return cliente.Valor * ((ClienteOuro)cliente).Juros;

            if (cliente.GetType() == typeof(ClienteVip))
                return cliente.Valor * ((ClienteVip)cliente).Juros;

            throw new Exception("Erro");
        }
    }
}