// See https://aka.ms/new-console-template for more information

   Console.WriteLine("***** CALCULADORA *****");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Elevar a la potencia");
    Console.Write("Seleccione una opción (1-5): ");

    int option = int.Parse(Console.ReadLine());

    if (option >= 1 && option <= 5)
    {
    Console.Write("Ingrese el primer número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    switch (option){
        case 1:
            Console.WriteLine("{0}", num1 + num2);
            break;
        case 2:
            Console.WriteLine("{0}", num1 - num2);
            break;
        case 3:
            Console.WriteLine("{2}", num1 * num2);
            break;
        case 4:
            Console.WriteLine("{2}", num1 / num2);
            break;
    }
 }


