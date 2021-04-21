using System;
using System.Collections.Generic;

namespace appProblemas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                int sel = Menu();
                Console.WriteLine(ListaProblemas(sel));
                Console.WriteLine("Desea continuar con este problema? (s or n)");
                string confirmacion = Console.ReadLine();
                if (confirmacion == "s")
                {
                    switch (sel)
                    {
                        case 1:
                            Problema1();
                            break;
                        case 2:
                            Problema2();
                            break;
                        case 3:
                            Problema3();
                            break;
                        case 4:
                            Problema4();
                            break;
                        case 5:
                            Problema5();
                            break;
                        case 6:
                            Problema6();
                            break;
                        case 7:
                            Problema7();
                            break;
                        case 8:
                            Problema8();
                            break;
                        case 9:
                            Problema9();
                            break;
                        case 10:
                            Problema10();
                            break;
                        case 11:
                            Problema11();
                            break;
                        case 12:
                            Problema12();
                            break;
                        case 13:
                            Problema13();
                            break;
                        case 14:
                            Problema14();
                            break;
                        case 15:
                            Problema15();
                            break;
                        case 16:
                            Problema16();
                            break;
                        case 17:
                            Problema17();
                            break;
                        case 18:
                            Problema18();
                            break;
                        case 19:
                            Problema19();
                            break;
                        case 20:
                            Problema20();
                            break;
                        case 21:
                            Problema21();
                            break;
                        case 22:
                            Problema22();
                            break;
                        case 23:
                            Problema23();
                            break;
                        case 24:
                            Problema24();
                            break;
                        case 25:
                            Problema25();
                            break;
                        case 26:
                            Problema26();
                            break;
                        case 27:
                            Problema27();
                            break;
                        case 28:
                            Problema28();
                            break;
                        case 29:
                            Problema29();
                            break;
                        case 30:
                            Problema30();
                            break;
                        case 31:
                            Problema31();
                            break;
                        case 32:
                            Problema32();
                            break;
                        case 33:
                            Problema33();
                            break;
                        case 34:
                            Problema34();
                            break;
                    }
                    exit = true;
                }
            }
            Console.ReadLine();
        }

        static int Menu()
        {
            int maxproblems = 34; //Si cambias esto, recuerda cambiar el indice en ListaProblemas() -> listproblemas
            Console.WriteLine($"Existen {maxproblems} problemas, selecciona uno para ver el enunciado.");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            while (seleccion <= 0 || seleccion > maxproblems)
            {
                Console.WriteLine("ERROR! INTRODUCE UN NUMERO CORRECTO");
                seleccion = Convert.ToInt32(Console.ReadLine());
            }
            return seleccion;
        }
        
        static string ListaProblemas(int num)
        {
            string[] listProblemas = new string[35];
            listProblemas[0] = "No deberias de estar leyendo esto 😠";
            listProblemas[1] = "Solicitar 5 números por consola y mostrar su media.";
            listProblemas[2] = "Ingresar un número y mostrar el cuadrado del mismo. El número debe ser mayor que cero, en caso de que no lo sea que aparezca el mensaje. ERROR.Introducir el número de nuevo; y se solicite la entrada de nuevo.";
            listProblemas[3] = "De 10 números introducidos por consola indicar cuántos son mayores a cero y cuántos son menores a cero.";
            listProblemas[4] = "Diseñar un algoritmo que calcule la longitud de la circunferencia y el área del círculo de radio solicitado por consola.";
            listProblemas[5] = "Diseñar un programa que calcule la superficie de un triángulo a partir de recoger por consola las dimensiones de su base y altura y muestre el resultado.";
            listProblemas[6] = "Ingresar un número e indicar si es positivo o negativo.";
            listProblemas[7] = "Mostrar si un número introducido por consola es par o impar.";
            listProblemas[8] = "Equivalencia de Grados Celsius con Grados Fahrenheit";
            listProblemas[9] = "Equivalencia de centímetros con pies y pulgadas.";
            listProblemas[10] = "Pedir por consola una frase y mostrar cuántas vocales tiene.";
            listProblemas[11] = "Mostrar en pantalla una lista de opciones con los días de la semana. Para elegir uno se debe introducir el número correspondiente. Una vez se ha introducido un número mostrar la opción elegida.";
            listProblemas[12] = "Mostrar los números impares entre el 0 y el 100.";
            listProblemas[13] = "Mostrar los números pares entre el 0 y el 100.";
            listProblemas[14] = "Mostrar los números del 0 al 100.";
            listProblemas[15] = "Mostrar los números del 100 al 0.";
            listProblemas[16] = "Mostrar los múltiplos de 3 del 0 al 100.";
            listProblemas[17] = "Mostrar los múltiplos de 3 y de 2 entre el 0 y 100.";
            listProblemas[18] = "Ingresar un número y mostrar la suma de los números que lo anteceden. Por ejemplo si se introduce un 6 el resultado es 5 + 4 + 3 + 2 + 1 = 15";
            listProblemas[19] = "Mostrar los números del 1 hasta el número ingresado.";
            listProblemas[20] = "Contar los múltiplos de 3 desde 1 hasta un número que ingresamos.";
            listProblemas[21] = "Mostrar los números primos entre el 0 y 100.";
            listProblemas[22] = "Ingresar 10 números sumar los positivos y multiplicar los negativos.";
            listProblemas[23] = "Ingresar dos números e intercambiarlos. Por ejemplo si introducimos 7 y 14, mostrar 14 y 7.";
            listProblemas[24] = "Ingresar un número y mostrar su cuadrado y cubo.";
            listProblemas[25] = "Introducir por consola el peso de 5 personas y mostrar la cantidad de personas que pesan más de 80 kg y menos de 80 kg.";
            listProblemas[26] = "Ingresar la longitud de los 3 lados de un triángulo y decir qué clase de triángulo es. Para formar un triángulo hay que tener en cuenta que la suma de la longitud de sus dos lados más cortos debe ser mayor que la longitud de su lado más largo.";
            listProblemas[27] = "Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo.";
            listProblemas[28] = "Por teclado se ingresa el valor hora de un empleado. Posteriormente se ingresa el nombre del empleado, la antigüedad en años y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar teniendo en cuenta que al total que resulta de multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumarle la cantidad de años trabajados multiplicados por 30,00 €, y al total de todas esas operaciones restarle el 13% en concepto de retenciones. Imprimir el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, el total de retenciones y el valor neto a cobrar.";
            listProblemas[29] = "Realizar la tabla de multiplicar de un número entre 0 y 10 de forma que se visualice de la siguiente forma: 4x1=4.";
            listProblemas[30] = "Solicitar 2 números por consola, imprimir los números naturales que hay entre ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares.";
            listProblemas[31] = "Se ingresa por teclado la cantidad de agua caída, en milímetros día a día durante un mes. Se pide determinar el día de mayor lluvia, el de menor y el promedio.";
            listProblemas[32] = "Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números que vamos introduciendo por teclado.";
            listProblemas[33] = "Crear un problema que solicite por consola el nombre de una persona seguido de una coma y su edad. Por ejemplo: Felipe, 43 Luego mostrar por consola todos los nombres y solo los nombres.";
            listProblemas[34] = "Crear un programa que reciba como entrada por consola una frase. El programa deberá retornar dicha entrada como una cadena de puntos (.) y guiones (-). Cada grupo de puntos(.) y guiones(-) representa una letra o símbolo. Cada grupo está separado de los demás con un espacio.";

            return listProblemas[num];
        }

        static void Problema1()
        {
            double[] nums = new double[5];
            double sum = 0;
            Console.WriteLine("Ingresa 5 numeros");
            for (var i = 0; i < 5; i++)
            {
                nums[i] = Convert.ToDouble(Console.ReadLine());
                sum += nums[i];
            }
            sum = sum / nums.Length;
            Console.WriteLine("La media de los numeros introducidos es: " + sum);
        }
        static void Problema2()
        {
            Console.WriteLine("Ingresa un numero");
            double num = Convert.ToInt32(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("ERROR. Ingresa el numero de nuevo");
                num = Convert.ToInt32(Console.ReadLine());
            }
            double result = Math.Pow(num, 2);
            Console.WriteLine("Resultado: " + result);
        }
        static void Problema3()
        {
            int greaterthan = 0;
            int lesserthan = 0;
            for (var i = 0; i < 10; i++)
            {
                double[] nums = new double[10];
                nums[i] = Convert.ToDouble(Console.ReadLine());
                if (nums[i] > 0)
                {
                    greaterthan++;
                }
                else
                {
                    lesserthan++;
                }
            }
            Console.WriteLine("Mayores que 0: " + greaterthan);
            Console.WriteLine("Menores que 0: " + lesserthan);
        }
        static void Problema4()
        {
            Console.WriteLine("Dame el radio");
            double radio = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;
            double longitud = 2 * pi * radio;
            double area = pi * (Math.Pow(radio, 2));




            Console.WriteLine("La longitud de la circunferencia redondeada es : " + Math.Round(longitud));
            Console.WriteLine("El area de la circunferencia redondeada es : " + Math.Round(area));
        }
        static void Problema5()
        {
            Console.WriteLine("Introduce la base del triangulo");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triangulo");
            double h = Convert.ToDouble(Console.ReadLine());

            double superficie = b * h / 2;


            Console.WriteLine("La superficie del triangulo es : " + superficie);
        }
        static void Problema6()
        {
            Console.WriteLine("Introduce un numero");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
        }
        static void Problema7()
        {
            Console.WriteLine("Introduce un numero");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        static void Problema8()
        {
            Console.WriteLine("Introduce los grados en Celsius");
            double grados = Convert.ToDouble(Console.ReadLine());

            double fahr = (grados * 9 / 5) + 32;


            Console.WriteLine("Los grados en fahrenheit: " + fahr + "ºF");
        }
        static void Problema9()
        {
            Console.WriteLine("Introduce los cm");
            double cm = Convert.ToDouble(Console.ReadLine());

            double pulgada = cm * 0.39370;
            double pie = cm * 0.032808;

            Console.WriteLine(cm + " cm en pulgadas es: " + pulgada);
            Console.WriteLine(cm + " cm en pies es: " + pie);
        }
        static void Problema10()
        {
            Console.WriteLine("Introduce la frase");
            string frase = Console.ReadLine();
            string vocales = "aeiou";
            int cuentavocales = 0;

            for (var i = 0; i < frase.Length; i++)
            {
                for (var j = 0; j < vocales.Length; j++)
                {
                    if (frase[i] == vocales[j])
                    {
                        cuentavocales++;
                    }
                }
            }

            Console.WriteLine(cuentavocales);
        }
        static void Problema11()
        {
            Console.WriteLine("Elige un dia");
            Console.WriteLine("1.Lunes 2.Martes 3.Miercoles 4.Jueves 5.Viernes 6.Sabado 7.Domingo");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("El numero introducido es erroneo");
                    break;
            }
        }
        static void Problema12()
        {
            Console.WriteLine("impares");
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Problema13()
        {
            Console.WriteLine("pares");
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Problema14()
        {
            Console.WriteLine("numeros 0-100");
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Problema15()
        {
            Console.WriteLine("numeros 100-0");
            for (var i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Problema16()
        {
            Console.WriteLine("numeros 0-100");
            for (var i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Problema17()
        {
            Console.WriteLine("numeros 0-100");
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Problema18()
        {
            Console.WriteLine("Dame un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 0;

            for (var i = num - 1; i > 0; i--)
            {
                res += i;
            }

            Console.WriteLine(res);
        }
        static void Problema19()
        {
            Console.WriteLine("Dame un numero");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            for (var i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Problema20()
        {
            Console.WriteLine("Dame un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (var i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Problema21()
        {

        }
        static void Problema22()
        {
            Console.WriteLine("Dame 10 numeros");
            int[] nums = new int[10];
            int sum = 0;
            for (var i = 0; i < 10; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                if (nums[i] > 0)
                {
                    sum = sum + nums[i];
                }
                else
                {
                    sum = sum * nums[i];
                }
            }

            Console.WriteLine(sum);
        }
        static void Problema23()
        {
            Console.WriteLine("Dame 2 numeros");
            int[] nums = new int[2];
            for (var i = 0; i < 2; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = nums[0];
            nums[0] = nums[1];
            nums[1] = temp;
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
        }
        static void Problema24()
        {
            Console.WriteLine("Dame 1 numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El cuadrado de " + num + " es: " + Math.Pow(num, 2));
            Console.WriteLine("El cubo de " + num + " es: " + Math.Pow(num, 3));
        }
        static void Problema25()
        {
            Console.WriteLine("Dame el peso de 5 personas");
            int[] num = new int[5];
            int greaterthan = 0;
            int lesserthan = 0;
            for (var i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] > 80)
                {
                    greaterthan++;
                }
                else
                {
                    lesserthan++;
                }
            }

            Console.WriteLine("Hay " + greaterthan + " personas que pesan mas de 80KG");
            Console.WriteLine("Hay " + lesserthan + " personas que pesan menos de 80KG");
        }
        static void Problema26()
        {

        }
        static void Problema27()
        {
            Console.WriteLine("Dame 3 numeros");
            int[] num = new int[3];
            for (var i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            if (num[1] > num[0])
            {
                if (num[1] < num[2])
                {
                    Console.WriteLine("Pertenece al intervalo");
                }
                else
                {
                    Console.WriteLine("No pertenece al intervalo");
                }
            }
            else
            {
                Console.WriteLine("No pertenece al intervalo");
            }
        }
        static void Problema28()
        {
            Console.WriteLine("Dame el valor por hora");
            double valorhora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el nombre del empleado");
            string name = Console.ReadLine();
            Console.WriteLine("Dame la antiguedad en años");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame la cantidad de horas trabajadas/mes");
            int horas = Convert.ToInt32(Console.ReadLine());
            // total = valorhora * horas + cantidad de años trabajados * 30
            double total = (valorhora * horas) + (years * 30);
            //retenciones = 13% = 13/100=0.13;
            double retenciones = total * 0.13;
            //resultado = total - retenciones
            double resultado = total - retenciones;

            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Antiguedad: " + years);
            Console.WriteLine("Valor por hora: " + valorhora);
            Console.WriteLine("Total en bruto: " + total);
            Console.WriteLine("Total en retenciones: " + retenciones);
            Console.WriteLine("Total neto: " + resultado);
        }
        static void Problema29()
        {
            Console.WriteLine("Dame un numero para mostrar su tabla (0~10)");
            int num = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + "x" + i + "=" + (num * i));
            }
        }
        static void Problema30()
        {
            Console.WriteLine("Dame dos numeros naturales");
            int[] nums = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int dif = nums[1] - nums[0];
            int contnum = 0;
            int conteven = 0;
            for (var i = 0; i <= dif; i++)
            {
                Console.WriteLine(nums[0] + i);
                contnum++;
                if ((nums[0] + i) % 2 == 0)
                {
                    conteven++;
                }
            }
            Console.WriteLine("Hay " + contnum + " numeros");
            Console.WriteLine("Pares: " + conteven);
        }
        static void Problema31()
        {

        }
        static void Problema32()
        {

        }
        static void Problema33()
        {

        }
        static void Problema34()
        {
            Console.WriteLine("Dame una frase para convertir a morse");
            string cadena = Console.ReadLine();
            string resultado = "";
            var abecedario = new Dictionary<string, string>
            {
                ["a"] = ".-",
                ["b"] = "-...",
                ["c"] = "-.-.",
                ["d"] = "-..",
                ["e"] = ".",
                ["f"] = "..-.",
                ["g"] = "--.",
                ["h"] = "....",
                ["i"] = "..",
                ["j"] = ".---",
                ["k"] = "-.-",
                ["l"] = ".-..",
                ["m"] = "--",
                ["n"] = "-.",
                ["ñ"] = "--.--",
                ["o"] = "---",
                ["p"] = ".--.",
                ["q"] = "--.-",
                ["r"] = ".-.",
                ["s"] = "...",
                ["t"] = "-",
                ["u"] = "..-",
                ["v"] = "...-",
                ["w"] = ".--",
                ["x"] = "-..-",
                ["y"] = "-.--",
                ["z"] = "--..",
                ["0"] = "-----",
                ["1"] = ".----",
                ["2"] = "..---",
                ["3"] = "...--",
                ["4"] = "....-",
                ["5"] = ".....",
                ["6"] = "-....",
                ["7"] = "--...",
                ["8"] = "---..",
                ["9"] = "----.",
                ["."] = ".-.-.-",
                [","] = "--..--",
                ["?"] = "..--..",
                [" "] = " "
            };
            for (var i = 0; i < cadena.Length; i++)
            {
                string temp = Convert.ToString(cadena[i]);
                resultado = resultado + abecedario[temp] + " ";
            }
            Console.WriteLine(resultado);
        }
    }
}
