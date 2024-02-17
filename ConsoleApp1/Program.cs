using System.ComponentModel.Design;

//Console.WriteLine("INGRESE UN NUMERO");
//int num = int.Parse(Console.ReadLine());
//if (num > 0)
//{
//    Console.WriteLine("El numero es positivo");
//}
//else if (num < 0)
//{
//    Console.WriteLine("El numero es negativo");
//}
//else
//{
//    Console.WriteLine("El numero es cero o neutro");
//}




//Console.WriteLine("INGRESE UN NUMERO");
//int edad = int.Parse(Console.ReadLine());
//if (edad > 18)
//{
//    Console.WriteLine("Puede entrar :)");
//}
//else if (edad < 18)
//{
//    Console.WriteLine("No puedes entrar jaja");
//}
//else
//{
//    Console.WriteLine("Apenas puedes entrar felicidades!!!");
//}




//Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO");
//int año = int.Parse(Console.ReadLine());

//if (año >= 1928 && año <= 1945)
//{
//    Console.WriteLine("Pertence a la generacion silenciosa");
//}

//else if (año >= 1946 && año <= 1964)
//{
//    Console.WriteLine("Pertence a la generacion baby boomer");
//}

//else if (año >= 1965 && año <= 1980)
//{
//    Console.WriteLine("Pertence a la generacion x");
//}

//else if (año >= 1981 && año <= 1996)
//{
//    Console.WriteLine("Pertence a la generacion de los milenial");
//}

//else if (año >= 1997 && año <= 2012){
//    Console.WriteLine("Pertence a la generacion Z");
//}

//else if (año >= 2013 )
//{
//    Console.WriteLine("Pertence a la generacion alfa");
//}
//else
//{
//    Console.WriteLine("Año invalido");
//}






//Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO");
//int año = int.Parse(Console.ReadLine());

//switch (año)
//{
//    case >= 1928 and <= 1945:

//        Console.WriteLine("Pertence a la generacion silenciosa");
//        break;

//    case >= 1946 and <= 1964:

//        Console.WriteLine("Pertence a la generacion baby boomer");
//        break;

//    case >= 1965 and <= 1980:

//        Console.WriteLine("Pertence a la generacion x");
//        break;

//    case >= 1981 and <= 1996:

//        Console.WriteLine("Pertence a la generacion de los milenial");
//        break;

//    case >= 1997 and <= 2012:

//        Console.WriteLine("Pertence a la generacion Z");
//        break;

//    case >= 2013:

//        Console.WriteLine("Pertence a la generacion alfa");
//        break;
//    default:

//        Console.WriteLine("Año invalido");
//        break;
//}







string nombre, pais;
int edad;
char genero;

Console.WriteLine("INGRESE EL NOMBRE");
nombre = Console.ReadLine().ToUpper();

Console.WriteLine("INGRESE LA EDAD");
edad = int.Parse ( Console.ReadLine());


Console.WriteLine("INGRESE EL PAIS");
pais = Console.ReadLine();

Console.WriteLine("INGRESE EL GENERO");
genero = char.Parse( Console.ReadLine().ToUpper());

if (!nombre.StartsWith("A") && (edad >= 18 || genero == 'F')
    && (pais == "Guatemala"|| pais == "Mexico"))
{
    Console.WriteLine("Si cumple con los requisitos");
}
else
{
    Console.WriteLine("Naranjas a la proxima");
}





