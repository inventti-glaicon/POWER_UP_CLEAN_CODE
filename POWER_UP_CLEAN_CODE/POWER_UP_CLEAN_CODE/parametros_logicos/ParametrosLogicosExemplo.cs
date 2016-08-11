using POWER_UP_CLEAN_CODE.parametros_logicos.dominio;

namespace POWER_UP_CLEAN_CODE.parametros_logicos
{
    public class ParametrosLogicosExemplo
    {
        public void Primeiro_Exemplo()
        {
            Pizza pizza = new Pizza();

            pizza.CriarPizza(new[] {"Chester", "Portuguesa", "Chocolate"}, "Grande", false);
            // Ninguém consegue falar sobre o útlimo parâmetro

            // Solução

            pizza.CriarPizzaAmericanaSemBorda(new[] {"Chester", "Portuguesa", "Chocolate"}, "Grande");


            pizza.CriarPizzaItalianaComBorda(new[] {"Chester", "Portuguesa", "Chocolate"}, "Grande");
        }


        public void Segundo_Exemplo()
        {
            TelaDoAtualizador tela = new TelaDoAtualizador();
            tela.DeveMostrarProgressBar(true);

            tela.DeveMostrarProgressBar(false);

            // Segundo o autor isso facilita a usabilidade da classe, sem prejudicar a legibilidade
            // Se alguém tiver interesse pode procurar por 'Boolean Setting Method'
        }

    }
}