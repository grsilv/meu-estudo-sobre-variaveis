// Aqui eu vou colocar coisas básicas que aprendi durante os estudos de C#

/* Primeiramente, vou começar com as variáveis, que são: inteiros, reais, caractere, booleano, string,
var, object, constante, enumeração e struct (essas últimas três não são tanto assim uma variável, mas pode-se
ser posta nessa lista). */

{
#region inteiro
// Integral Assinado
sbyte num1 = 10; // 8 bits, de -128 a 127.
short num2 = 11; // 16 bits, -37.768 e 32.767
int num3 = 12; // 32 bits, -2147.483.648 a 2.147.483.647
long num4 = 13; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

//Integral sem sinal

byte num5 = 20; // 8 bits, intervalo de 0 a 255
ushort num6 = 21; // 16 bits, de 0 a 65.535
uint num7 = 22; // 32 bits, de 0 a 4.294.967.295
ulong num8 = 23L; // 64 bits, de 0 a 18.446.744.073.709.551.615

// Teste

sbyte numero = 200; // vai dar erro, pois 200 está fora da abrangência.
sbyte numero2 = -150; // mesma coisa.
sbyte numero3 = 100; /* porém, caso não queira atribuir nenhum
valor a esta variável: */ sbyte numero3;

sbyte numero4;
numero4 = 4;
#endregion

#region reais
float = 32 bits;
double = 64 bits;
decimal = 128 bits;
#endregion

#region tipo caractere
char letra = 'C';
char escape = '\n'; // tornar o char nulo
char enter = '\u0013' // adicionar código de tecla 
#endregion

#region tipo booleano
bool oi = false;
bool tudo = true;
#endregion

#region tipo string
string declaração = "Eu te amo"; // string é variável de texto
#endregion

#region tipo var
var valor = 140;
var valor = "texto";
var valor = 'C';
var valor = 12.20;
var valor = true;

// Podemos usar quando não sabemos que tipo de valor iremos receber.
#endregion

#region tipo object
object obj; //pode atribuir qualquer valor

// é a base para todos os valores

obj = 101;
obj = "oi!";
#endregion

#region tipo constante
// o valor de uma constante não pode ser variado.

const double pi = 3.1415;
pi = 25; // está errado! o valor não pode ser alterado.
#endregion

#region enumeração
class Program
{
		enum notas 
		{
				Mínimo = 0, Média = 5, Máxima = 10
			}

//

Notas notasAlunos = Notas.Media;
#endregion

#region struct
// Se tiver muita variável para fazer, diminuir com a estrutura

class Program 
{
		struct Pessoa 
		{
				public string nome; // sem o public, não da pra acessar os valores 
				public int idade;
				public double altura;
		}

//

Pessoa p1 = new Pessoa();
p1.altura = 1.75;
p1.idade = 65;
p1.nome = "José";

Pessoa p2 = new Pessoa()
{
	nome = "Arthur",
	idade = 9,
	altura = 1.60
};

p1.nome = "Pedro"; //alterando o nome...

Console.WriteLine(p1.altura);
Console.WriteLine(p1.idade);
Console.WriteLine(p1.nome);

Console.WriteLine(); //quebra de linha

Console.WriteLine(p2.altura);
Console.WriteLine(p2.idade);
Console.WriteLine(p2.nome);

// sem o public, daria erro por conta que não ficaria vísivel.
#endregion

// Foi isso. Mais para apresentar o meu aprendizado, mesmo. Não recomendo copiar isso como se fosse um código para alguma coisa, por exemplo. Tchau!

}
