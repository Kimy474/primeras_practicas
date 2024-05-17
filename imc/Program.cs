// See https://aka.ms/new-console-template for more information
Console.WriteLine("hola, Vamos a calcular tu IMC. Dime tu peso");

float peso= float.Parse(Console.ReadLine());

Console.WriteLine("Ahora, dime tu altura");

float altura= float.Parse(Console.ReadLine());

float imc= peso / (altura*altura);

if(imc<=18.5){
    Console.WriteLine("Estas bajo de peso");
}
else if(imc>=24.9){
    Console.WriteLine("Estas en el peso ideal");
}

else if(imc>=29.9){
    Console.WriteLine("Estas en sobrepeso");

}

else if(imc>=31){
    Console.WriteLine("Estas obeso");
}


Console.WriteLine("Tu indice: " + imc);
Console.WriteLine("Cuida tu salud");
