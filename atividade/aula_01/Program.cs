// See https://aka.ms/new-console-template for more information
using aula_01;

Console.WriteLine("Hello, World!");

/*
NEW TipoEnumerador () > invoca o metodo contrutor do objeto;
toda classe tem o seu construtor padrao implicito sem argumentos/parametros
é possivel sobrescrever esse metodo especidficando argumentos
todavia, se o fizermos, perdemos o orginal implicito
e precisaremos defini-los explicitamente
*/

TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = 
tipoEnum.GetLanguageEnum("ingles");

Console.WriteLine( $"o enum de english é {enumEnglish}" );