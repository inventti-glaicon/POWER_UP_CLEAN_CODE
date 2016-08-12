using System;
using POWER_UP_CLEAN_CODE.retornar_null.dominio;

namespace POWER_UP_CLEAN_CODE.retornar_null
{
    public class RetornarNullExemplo
    {
        public void Primeiro_Exemplo()
        {
            Pizza pizza = new Pizza();

            var sabores = pizza.ObterSabores(TipoDaPizza.Americana);
            if (sabores != null) // Validação aqui 
                Console.Write(String.Join(" ,", sabores));

            sabores = pizza.ObterSabores(TipoDaPizza.Italiana);
            if (sabores != null) // Validação aqui 
                Console.Write(String.Join(" ,", sabores));

            sabores = pizza.ObterSabores(TipoDaPizza.Vegetariana);
            if (sabores != null) // Validação aqui 
                Console.Write(String.Join(" ,", sabores));

            // Esse é um dos problemas de retornar null, sempre vamos ser obrigados a validar o retorno da função
            // Dessa forma criamos trabalho para nós mesmo e repassamos para quem estiver usando

            OutroProcessoEmOutroLugar(pizza);
        }

        private void OutroProcessoEmOutroLugar(Pizza pizza)
        {
            // Só precisa um desavisado esquecer de fazer a validação para dar crash
            var sabores = pizza.ObterSabores(TipoDaPizza.Vegetariana);
            Console.WriteLine(String.Join(" ,", sabores));
        }

        public void Solucao()
        {
            PizzaSolucao pizza = new PizzaSolucao();

            // Solução
            // Retornar uma exceção ou um objeto vazio - Link compartilhado Padrão de Projeto: Objeto Nulo - http://www.thiengo.com.br/padrao-de-projeto-objeto-nulo
            var sabores = pizza.ObterSabores(TipoDaPizza.Vegetariana);
            Console.Write(String.Join(" ,", sabores));
        }
    }
}