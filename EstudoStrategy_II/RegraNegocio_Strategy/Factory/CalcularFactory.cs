using RegraNegocio_Strategy.Entities;
using RegraNegocio_Strategy.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegraNegocio_Strategy.Factory
{
   
    public   class CalcularFactory 
    {
        List<enumOperacoes>  ListaOperacao = new List<enumOperacoes>();
        public double OperacaoEscolhida(enumOperacoes tipo, double v1,double v2)
        {
            foreach (enumOperacoes item in System.Enum.GetValues(typeof(enumOperacoes)))
            {
                ListaOperacao.Add(item);
            }
            foreach (var tipoOp in ListaOperacao)
            {
                if (tipoOp.Equals(tipo))
                {
                    Calcular c = new Calcular();
                   return c.CalcularOperacao(tipo, v1, v2);
                }
            }

            return 0;
           
        }
   }
}
