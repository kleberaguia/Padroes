using RegraNegocio_Strategy.Entities.Interfaces;
using RegraNegocio_Strategy.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegraNegocio_Strategy.Entities.ClassesConcretas
{
    public class Subtracao : ICalcular
    {

        public double Calcular(double v1, double v2)
        {
            return (v1 - v2);
        }

    }
}
