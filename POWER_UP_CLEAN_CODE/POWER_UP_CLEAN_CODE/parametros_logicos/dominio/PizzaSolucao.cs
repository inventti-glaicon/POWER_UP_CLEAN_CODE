namespace POWER_UP_CLEAN_CODE.parametros_logicos.dominio
{
    public class PizzaSolucao
    {
        //todo ver exemplo que está no livro
        private string[] saboresDaPizza;
        private string tamanhoPizza;
        private bool temBorda;
        private bool ehPizzaFina;
        
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