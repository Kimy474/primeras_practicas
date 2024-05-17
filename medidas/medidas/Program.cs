// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, dime la base de tu rectangulo");
float bases= float.Parse(Console.ReadLine());

Console.WriteLine("Ahora, dime la altura de tu rectangulo");
float altura= float.Parse(Console.ReadLine());

float area= bases * altura;
float perimetro= (altura*altura) * bases;
Console.WriteLine("El area de tu rectangulo es " + area);
Console.WriteLine("Y el perimetro de tu rectangulo es " + perimetro);

Console.WriteLine("Espero haberte sido de ayuda");