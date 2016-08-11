using System.Threading;

namespace POWER_UP_CLEAN_CODE.parametros_saida.dominio
{
    public class PizzaSolucao
    {
        public bool EstaFatiada { get; set; }

        public void Fatiar()
        {
            Thread.Sleep(300);
        }
    }
}