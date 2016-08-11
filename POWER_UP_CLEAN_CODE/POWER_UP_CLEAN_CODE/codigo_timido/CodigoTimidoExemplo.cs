﻿namespace POWER_UP_CLEAN_CODE.codigo_timido
{
    public class CodigoTimidoExemplo
    {
        public void Primeiro_Exemplo()
        {
            Quadrado quadrado = new Quadrado();
            int area = quadrado.Altura * quadrado.Largura;
            // Atributos da classe estão visíveis para todos,
            
            OutroProcesso(quadrado);

            OutraClasseDoCodigo(quadrado);

            quadrado.Area();
        }

        private void OutraClasseDoCodigo(Quadrado quadrado)
        {
            // Somos obrigados a recompilar todos os códigos
            int area = quadrado.Altura * quadrado.Largura;
        }

        private void OutroProcesso(Quadrado quadrado)
        {
            // Cada um tem a chance de fazer um calculo diferente
            int area = quadrado.Altura * quadrado.Largura;
        }
    }
}