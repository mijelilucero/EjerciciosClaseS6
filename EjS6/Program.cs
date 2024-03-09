static void suma()
{
    int num1, num2, resultado = 0;

    Console.WriteLine("Ingrese n1: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese n2: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    resultado = num1 + num2;
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


//string nombre = datos();
//Console.WriteLine("Tu nombre es: " + nombre);

//int promedio = sumatoria(20, 25, 40) / 3;
//Console.WriteLine("promedio= " + promedio);

//int edad = calculoEdad();
//Console.WriteLine("Tu edad es: " + edad);



//int opc = 0;
//do
//{
//    Console.WriteLine("1. Suma");
//    Console.WriteLine("2. Datos");
//    Console.WriteLine("3. Nacimiento");
//    Console.WriteLine("4. Salida");
//    opc = Convert.ToInt32(Console.ReadLine());

//    switch (opc)
//    {
//        case 1:
//            suma();
//            break;

//        case 2:
//            datos();
//            break;

//        case 3:
//            calculoEdad();
//            break;

//        case 4:
//            break;
//    }
//} while (opc != 4);







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




