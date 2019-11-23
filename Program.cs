using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            var Estudiantes = new List<Estudiante>();
            var Agregar = true;

            
                //ciclo
                while (Agregar)
                {
                    
                    try
                    {


                        var e = new Estudiante();

                        bool result;
                        int Matricula = 0;




                        int M = e.Matricula;
                        //no se puede poner e.Matricula en el out por que no acepta algo diferente de una variable
                        Console.WriteLine("ingrese matricula: ");
                        //int.TryParse(Console.ReadLine(),out M);

                        result = int.TryParse(Console.ReadLine(), out M);
                        if (result == false)
                        {

                            Console.WriteLine("error ingrese numeros en matricula: ");
                            //servia para agregar un dato
                            int.TryParse(Console.ReadLine(), out M);
                        }

                        //el try parce 



                        //!M mismo error no se puede aplicar cuando es int
                        //M == false no se puede aplicar a operadores de int y boll


                        /*if (M == 0)
                        {// se arreglo con 0 por que retorna
                            Console.WriteLine("erro ingrese un numero");
                        }
                        */

                        //Captura de los datos  
                        Console.WriteLine("ingrese Nombre: ");
                        e.Nombre = Console.ReadLine();

                        Console.WriteLine("ingrese carrera");
                        e.Carrera = Console.ReadLine();

                        Console.WriteLine("ingrese semestre:");
                        e.Semestre = Convert.ToInt32(Console.ReadLine());

                        Estudiantes.Add(e);

                        Console.WriteLine("¿quiere agregar otro usuario:? Y/N");
                        //condicion para verificar si el usuario realizara otro registro o no
                        if (Console.ReadLine() != "Y")
                            //c tab . r tab = al console.redline
                        {
                            Agregar = false;

                            
                        }





                    }
                    catch (Exception)
                    {//mensaje que se muestra cuando el registro salio mal o no se realizo con los parametros correctos
                        Console.WriteLine("error de resitro intente de nuevo");
                    Console.ReadKey();
                       
                    }

                   
                
                }


            //Resumen
            /* Durante el desarrollo de este programa realizamos esta solucion la cual tiene como funcionamiento capturar los datos de un
             * estudiante, los cuales son matricula,Nombre, carrera y semestre al capturarlos el programa deve mandar una advertencia en caso
             de que la matricula este mal escrita y te diga que te de la opcion de ingresar nuevamente la matricula , aparte de esto en caso 
             de que el usuario escriba mal algun otro dato o no ingrese ninguno al final del registro se tiene que mostrar un mensaje que diga
             error en registro y se reinicie el registro.

             Sin embargo en la clase el objetivo de este programa eran los errores que se podrian producir y como solucionarlos por lo que provamos
             con diversas maneras de captar un error y tambien evitarlos para eso utilizamos erramientas como son if , try catch y excepcion entre mas 
             ademas de diversas condiciones.

             Entre los errores a los cuales nos enfrentamos hubo algunos curiosos como poder captar cuando un usuario ingresaba un tipo texo y al mismo
             tiempo un tipo numerico y captarlos mandandole al  usuario una advertencia este error se corrigio de la siguiente manera:


             if (M == 0)
                     {// se arreglo con 0 por que retorna
                         Console.WriteLine("erro ingrese un numero");
                     }
                     

            Otro error que se pudo notar fue el de que no podiamos usar 
                el dato e.matricula en un out y esto lo resolvimos asignando a una variable M = e.matricula. 

              Existieron mas errores pero estos fueron algunos que resalto, en conclucion existen muchas maneras de corregir errores solo es
              cuestion de revisar la logica del problema y usar las herramientas que el legunaje nos proporciona. 
                   
             */


           
            
            

        }
    }
}

