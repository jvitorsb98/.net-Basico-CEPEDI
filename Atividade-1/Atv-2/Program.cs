/*Os valores escolhidos são os limites positivos de 
armazenamento de cada tipo de dado inteiro
*/
sbyte umByteComSinal = 127;
byte byteSemSinal = 255;
short inteiroShortComSinal = 32767;
ushort inteiroShortSemSinal = 65535;
int valorInteiroComSinal = 2147483647;
uint valorInteiroSemSinal = 4294967295;
long longComSinal = 9223372036854775807;
ulong longSemSinal = 18446744073709551615;
nint inteiroNativoComSinal = 2147483647;
nuint inteiroNativoSemSinal = 4294967295;

Console.WriteLine("Maximo de um sbyte : " + umByteComSinal);
Console.WriteLine("Maximo de um byte : " + byteSemSinal);
Console.WriteLine("Maximo de um short : " + inteiroShortComSinal);
Console.WriteLine("Maximo de um ushort : " + inteiroShortSemSinal);
Console.WriteLine("Maximo de um int : " + valorInteiroComSinal);
Console.WriteLine("Maximo de um uint : " + valorInteiroSemSinal);
Console.WriteLine("Maximo de um long : " + longComSinal);
Console.WriteLine("Maximo de um ulong : " + longSemSinal);
Console.WriteLine("Maximo de um nint(depende da plataforma, pode ser 64bits) : " + inteiroNativoComSinal);
Console.WriteLine("Maximo de um unint(depende da plataforma, pode ser 64bits) : "+ inteiroNativoSemSinal);


/*O uso vai depender do valor necessário para a aplicação 
e a possibilidade de ignorar os valores negativos;*/
