using System;
using POWER_UP_CLEAN_CODE.polimorfismo_inves_switchs.dominio;

namespace POWER_UP_CLEAN_CODE.polimorfismo_inves_switchs
{
    public class PolimorfismoExemplo
    {
        //Princípio de Aberto para extensões e Fechado para alterações - OCP
        public void Primeiro_Exemplo()
        {
            ClienteOuro clienteOuro = new ClienteOuro();
            ClientePrata clientePrata = new ClientePrata();
            ClienteVip clienteVip = new ClienteVip();

            Banco banco = new Banco();

            var valorPrata = banco.PegarEmprestimo(clientePrata);
            var valorOuro = banco.PegarEmprestimo(clienteOuro);
            var valorVip = banco.PegarEmprestimo(clienteVip);
            
            //Aplicar essa abordagem também é uma violaçao do Open/Close principles
        }

        public void Solucao()
        {
            ClienteOuroSolucao clienteOuro = new ClienteOuroSolucao();
            ClientePrataSolucao clientePrata = new ClientePrataSolucao();
            ClienteVipSolucao clienteVip = new ClienteVipSolucao();

            BancoSolucao banco = new BancoSolucao();

            //Solução
            var valorPrata = banco.PegarEmprestimo(clientePrata);
            var valorOuro = banco.PegarEmprestimo(clienteOuro);
            var valorVip = banco.PegarEmprestimo(clienteVip);
        }
    }
}