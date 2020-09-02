using RegraNegocio_Strategy.Entities.Interfaces;
using RegraNegocio_Strategy.Factory;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RegraNegocio_Strategy.Entities
{
    public class Calcular
    {
        const string objectToInstantiate = "RegraNegocio_Strategy.Entities.ClassesConcretas";
        public CalcularFactory calcular { get; set; }
        public double CalcularOperacao(Enum.enumOperacoes tipo, double v1, double v2)
        {
            var obj = objectToInstantiate + "." + tipo.ToString() + ",RegraNegocio_Strategy";
            var objectType = Type.GetType(obj);
            PropertyInfo[] properties = objectType.GetProperties();
            var instantiatedObject = Activator.CreateInstance(objectType) as ICalcular;
            return instantiatedObject.Calcular(v1, v2);
           

        }

    }

}
