using System;
using System.Collections.Generic;

namespace POWER_UP_CLEAN_CODE.retornar_null.dominio
{
    public class PizzaSolucao
    {
        public List<string> ObterSabores(TipoDaPizza tipoDaPizza)
        {
            switch (tipoDaPizza)
            {
                case TipoDaPizza.Americana:
                    return new List<string>() { "Calabresa", "Mussarela" };

                case TipoDaPizza.Italiana:
                    return new List<string>() { "Carne", "Mussarela", "Tomates" };

                default: return new List<string>();
                    throw new Exception("Tipo de pizza não implementado");
            }
        }
    }
}