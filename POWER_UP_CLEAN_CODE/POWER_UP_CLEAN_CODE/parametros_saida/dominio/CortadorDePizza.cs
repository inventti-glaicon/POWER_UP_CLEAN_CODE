using System.Threading;

namespace POWER_UP_CLEAN_CODE.parametros_saida.dominio
{
    public class CortadorDePizza
    {
        public bool CortarPizza(Pizza pizza)
        {
            Thread.Sleep(320);

            // Pode indicar outro problema 
            pizza.EstaFatiada = true;

            return true;
        }
    }
}