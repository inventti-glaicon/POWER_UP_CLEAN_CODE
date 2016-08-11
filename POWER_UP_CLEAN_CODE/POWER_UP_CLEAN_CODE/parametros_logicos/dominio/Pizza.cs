namespace POWER_UP_CLEAN_CODE.parametros_logicos.dominio
{
    public class Pizza
    {
        //todo ver exemplo que está no livro
        private string[] saboresDaPizza;
        private string tamanhoPizza;
        private bool temBorda;
        private bool ehPizzaFina;

        public void CriarPizza(string[] sabores, string tamanho, bool ehPizzaAmericana)
        {
            saboresDaPizza = sabores;
            tamanhoPizza = tamanho;


            // Além de complicar a legibilidade é um indicativo claro que o método faz mais que um coisa

            if (ehPizzaAmericana)
            {
                temBorda = false;
                ehPizzaFina = true;
            }
            else
            {
                temBorda = true;
                ehPizzaFina = false;
            }
        }
        
        public void CriarPizzaAmericanaSemBorda(string[] sabores, string tamanho)
        {
            saboresDaPizza = sabores;
            tamanhoPizza = tamanho;

            temBorda = false;
            ehPizzaFina = true;
        }

        public void CriarPizzaItalianaComBorda(string[] sabores, string tamanho)
        {
            saboresDaPizza = sabores;
            tamanhoPizza = tamanho;

            temBorda = true;
            ehPizzaFina = false;
        }
    }
}