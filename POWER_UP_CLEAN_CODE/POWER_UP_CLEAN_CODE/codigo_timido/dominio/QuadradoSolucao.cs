namespace POWER_UP_CLEAN_CODE.codigo_timido.dominio
{
    public class QuadradoSolucao
    {
        public int Altura { get; set; }
        public int Largura { get; set; }

        // Quando concentramos o código em um mesmo código, nao precisamos varrer tod o código em busca dos atributos
        // Evitando que recompilar as dlls
        public int Area()
        {
            return Altura * Largura;
        }
    }
}