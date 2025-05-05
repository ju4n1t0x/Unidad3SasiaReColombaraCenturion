using System;

namespace Unidad3SasiaReColombaraCenturion
{

    class Program
    {
        static void Main(string[] args)
        {
          
            //Llamo la funcion del ejercicio 2
            int numero = ingresarNumero("Ingrese un numero");
            Console.WriteLine("El numero ingresado es: " + numero);

            //Llamo la funcion del ejercicio 3
            string mensaje = mensajeComoParametro("Soy el mensaje ingresado como parametro");


            //Llamo la funcion del ejercicio 4
            menorOIgual(ref numero, ref mensaje);

            
            //Llamo la funcion del ejercicio 5
            esMultiplo(ref numero, ref mensaje);

        }



        /**
         * 2- Crear una función que pida que al usuario ingrese un numero entero. 
         * Verificar que se haya ingresado un número y sino se muestre un mensaje de error y 
         * vuelva a solicitar el ingreso de un número.
         * 
         */
        static int ingresarNumero(string mensaje ) 
            {
            int numero;
            Console.WriteLine(mensaje);
            while(!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("El valor ingresado no es un numero, intente nuevamente");
            }
            return numero;
            }


        /**
         * 3-Crear una función que muestre un mensaje pasado como parámetro. 
         */
        static string mensajeComoParametro(string mensaje) {
            Console.WriteLine(mensaje);
            return mensaje;
        }

        /**
         * 4- Crear una función para validar si un numero es menor o igual a 50 
         * usando el numero ingresado en el punto 2 y usando la función del punto 3 para mostrar el mensaje.
         */
        static void menorOIgual(ref int numero, ref string mensaje) {
            if (numero < 50)
            {
                mensaje = "El numero ingresado es menor a 50";

            }
            else if (numero == 50)
            {
                mensaje = "El numero ingresado es igual a 50";
            }
            else {
                mensaje = "El numero ingresado es mayor a 50"; ;
            }
            mensajeComoParametro(mensaje);
        }

        /**
         * 5- Crear una función para validar si un numero es múltiplo de 7 
         * usando el numero ingresado en el punto 2 y usando la función del punto 3 
         * para mostrar el mensaje.
         */

        static void esMultiplo(ref int numero, ref string mensaje)
        {
            if (numero %7 == 0)
            {
                mensaje = "El numero ingresado es multiplo de 7";

            }
            else {
                mensaje = "El numero ingresado no es multiplo de 7"; ;
            }
            mensajeComoParametro(mensaje);
        }
    }
}


