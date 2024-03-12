static void suma()
{
    int num1, num2, resultado = 0;

    Console.WriteLine("Ingrese n1: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese n2: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    resultado = num1 + num2;
    Console.WriteLine("El resultado de la suma es: "+resultado);
}

static string datos()
{
    Console.WriteLine("Ingrese Nombre: ");
    string nombre = Console.ReadLine();

    return nombre;
}

static int calculoEdad()
{
    Console.WriteLine("Ingrese su año de nacimiento: ");
    int año_nacimiento= Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - año_nacimiento;

    return edad;
}

static int sumatoria(int num1, int num2, int num3)
{
    int resultado = 0;
    resultado=num1+ num2 + num3;
    return resultado;
}



//EJERCICIOS PARA PRÁCTICA
static void MaxyMin()
{
int num, max = int.MinValue, min=int.MaxValue;

do
{
    Console.WriteLine("Ingrese un numero: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > max)
    {
        max = num;
    }

    if (num < min && num!=0)
    {
        min = num;
    }

} while (num != 0);

Console.WriteLine("El numero mayor es: "+ max);
Console.WriteLine("El numero menor es: " + min);
}


static void adivinarNum()
{
    Console.WriteLine("Piensa en un número");
    Console.WriteLine("Presiona una tecla cuando estes listo...");
    Console.ReadKey();

    Console.WriteLine("\nMultiplicalo por 2");
    Console.WriteLine("Presiona una tecla cuando lo tengas...");
    Console.ReadKey();

    Console.WriteLine("\nSumale 8 al resultado");
    Console.WriteLine("Presiona una tecla cuando lo tengas listo...");
    Console.ReadKey();

    Console.WriteLine("\nAl resultado multiplícalo por 5");
    Console.WriteLine("Presiona una tecla cuando tengas el resultado...");
    Console.ReadKey();

    Console.WriteLine("\nIngresa el resultado que obtuviste:");
    int resultado = Convert.ToInt32(Console.ReadLine());

    int sinUlt = resultado / 10;
    int numero= sinUlt - 4;

    Console.WriteLine("\n\nEL NÚMERO QUE PENSASTE ES: "+ numero);
}


static void contPalabras()
{
    int contpalabras = 0, contvocales = 0;

    Console.WriteLine("Escriba una frase: ");
    string frase = Console.ReadLine().ToUpper();

    int i = 0;

    while (i < frase.Length)
    {
        if (i == 0 || frase[i - 1] == ' ' && frase[i] != ' ')
        {
            contpalabras++;
        }

        if (frase[i] == 'A' || frase[i] == 'E' || frase[i] == 'I' || frase[i] == 'O' || frase[i] == 'U')
        {
            contvocales++;
        }

        i++;
    }

    Console.WriteLine("El numero de palabras es: "+ contpalabras);
    Console.WriteLine("El numero de vocales es: " + contvocales);
}


static void verificarPolindromo()
{
    Console.WriteLine("Ingrese un palíndromo: ");
    string frase = Console.ReadLine().ToLower();

    string palindromo = frase.Replace(" ", string.Empty);
    int longitud = palindromo.Length;

    int principio = 0;
    bool comprobacion = true;

    for (int i = longitud - 1; i >= 0; i--)
    {
        if (palindromo[principio] != palindromo[i])
        {
            comprobacion = false;
        }
        principio++;
    }

    if (comprobacion == true)
    {
        Console.WriteLine("El texto ingresado SI es un palindromo.");
    }
    else
    {
        Console.WriteLine("El texto ingresado NO es un palindromo.");
    }
}


int opcion = 0;
do
{
    Console.Clear();
    Console.WriteLine("1. Numero máximo y mínimo ingresado,");
    Console.WriteLine("2. Adivinar el número que el usuario está pensando.");
    Console.WriteLine("3. Contador de palabras.");
    Console.WriteLine("4. Comprobación de palíndromos.");
    Console.WriteLine("5. Ejercicios de ejemplo en clase Semana 6");
    Console.WriteLine("6. Salir");
    Console.WriteLine("\nIngrese una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear(); 
            MaxyMin();
            Console.ReadKey();
            break;

        case 2:
            Console.Clear();
            adivinarNum();
            Console.ReadKey();
            break;

        case 3:
            Console.Clear();
            contPalabras();
            Console.ReadKey();
            break;

        case 4:
            Console.Clear();
            verificarPolindromo();
            Console.ReadKey();
            break;

        case 5:
            Console.Clear();
            int opcSubmenu = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Datos");
                Console.WriteLine("3. Nacimiento");
                Console.WriteLine("4. Sumatoria");
                Console.WriteLine("5. Regresar al menu anterior");
                Console.WriteLine("\nIngrese una opción: ");
                opcSubmenu = Convert.ToInt32(Console.ReadLine());

                switch (opcSubmenu)
                {
                    case 1:
                        Console.Clear();
                        suma();
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        string nombre = datos();
                        Console.WriteLine("Tu nombre es: " + nombre);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        int edad = calculoEdad();
                        Console.WriteLine("Tu edad es: " + edad);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        int promedio = sumatoria(20, 25, 40) / 3;
                        Console.WriteLine("promedio= " + promedio);
                        Console.ReadKey();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Ingrese una opción válida.");
                        Console.ReadKey();
                        break;
                }
            } while (opcSubmenu != 5);
            break;

        case 6:
            break;

        default:
            Console.WriteLine("Ingrese una opción válida.");
            Console.ReadKey();
            break;
    }
} while (opcion != 6);