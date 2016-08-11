using POWER_UP_CLEAN_CODE.parametros_saida.dominio;

namespace POWER_UP_CLEAN_CODE.parametros_saida
{
    public class ParametrosSaidaExemplo
    {
        public void Primeiro_Exemplo()
        {
            CortadorDePizza cortador = new CortadorDePizza();
            var pizza = new Pizza();
            bool pizzaCortada = cortador.CortarPizza(pizza);
            // Não é natural você esperar que esse parâmetro seja o retorno da função, isso pode causar confusão ao entender o código

            // FAZ ALGUMA COISA 

            if (pizza.EstaFatiada)
            {
                // Pizza está pronta para ser servida
            }
            else
            {
                // Pizza não pode ser servida
            }


            // Solução
            pizza.Fatiar();
            // Dessa forma quem está alterando o estado do atributo de pizza é o seu próprio objeto
            // Caso seja necessário, pelo menos que deixe explicíto a inteção utilizando o 'REF'
        }
    }
}