using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexisAleTrabajoPractico8
{
    class ClaseCalculadora
    {
        //constructor

        private float numero1;
        private float numero2;
        public string operador;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        public float Suma()
        {
            return (numero1+numero2);
        }
        public float Resta()
        {
            return (numero1-numero2);
        }
        public float Multiplicacion()
        {
            return (numero1*numero2);
        }
        public float Division()
        {
            if(numero2 == 0)
            {
                return (-9999);
            }
            else
            {
                return (numero1/numero2);
            }
        }

    }
    /*
     3) Implementar una calculadora que tenga disponibles las siguientes operaciones:
         Suma
         Resta
         Multiplicación
         División
        Para ello implementará el uso de una clase denominada Calculadora con los siguientes
        atributos y métodos
         Numero1 //punto flotante
         Numero2 //punto flotante
         Suma() //devuelve el resultado de  Numero1 + Numero2
         Resta() //devuelve el resultado de  Numero1 - Numero2
         Multiplicacion() //devuelve el resultado de  Numero1 * Numero2
         Division() //devuelve el resultado de  Numero1 / Numero2 , haga el control
        correspondiente para evitar la división por 0
     */
}
