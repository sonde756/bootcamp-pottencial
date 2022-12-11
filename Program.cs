using Projeto.Models;



































// Calculadora calc = new Calculadora();

// int soma = 0, numero = 0;

// do 
// {
//      Console.WriteLine("Digite um numero (0 para parar)");
//      numero = Convert.ToInt32(Console.ReadLine());
     
//      soma += numero;

// } while(numero !=0);

// Console.WriteLine($"Total da soma é {soma}");




























// int numero = 100;
// int contador = 1;

// while(contador < 211)
// {
//  Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");

//  contador++;
 
//  if (contador == 6)
//  {
//      break;
//  }

// }




















































// Console.WriteLine("Digite o valor da tabuada");
// int numero = Convert.ToInt32(Console.ReadLine());

// for(int contador = 0; contador <= 100; contador++)
// {
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



// Console.WriteLine("Valor para incremento");
//  int Numero = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine($"Incrementando o {Numero} com 'Numero++'");
//  Numero++;
//  Console.WriteLine(Numero);


//  Console.WriteLine("Valor para decremento");
//  int Numero2 = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine($"Decrementando o {Numero2} com 'Numero--'");
//  Numero2--;
//  Console.WriteLine(Numero2);








//  Console.WriteLine("Valor 1");
//     int numb = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Valor 2");
//     int numb2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Valor 1");
//      int numb = Convert.ToInt32(Console.ReadLine());
// calc.RaizQuadrada(numb);

//  calc.Seno(30);
//  calc.Coseno(30);
//  calc.Tagente(30);
//  calc.Potencia(numb , numb2);
//  calc.Somar(numb , numb2);
//  calc.Subtracao(numb , numb2);
//  calc.Multiplicacao(numb , numb2);
//  calc.Divisao(numb , numb2);



// bool choveu = true;
// bool estaTarde = true;

// if(choveu && estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedala outro dia");
// }




// bool possuiPresencaMinima = false;
// double media = 7.5;


// if(possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }





// bool ehMaiorDeidade = true;
// bool possuiAutorizacaoDoResponsavel = false;



// if(ehMaiorDeidade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada permitida");
// }
// else
// {
//     Console.WriteLine("Entrada não permitida");
// }






// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }






// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u")
//    {
//     Console.WriteLine($"{letra} é Vogal");
//    }
//    else
//    {
//     Console.WriteLine($"{letra} não é vogal");
//    }





//  int quantiadeEmEstoque = 10; // Quantidade disponivel para compra.

//  int quantidadeCompra = 0; // quantidade comprada.
//  bool possivelVenda = quantidadeCompra > 0 && quantiadeEmEstoque >= quantidadeCompra; // Verificar se é possivel esta realizando a venda com quantidade de produto disponivel.

//  Console.WriteLine($"Quantidade em estoque: {quantiadeEmEstoque}"); //Exibir quantidade estoque.
//  Console.WriteLine($"Quantidade compra: {quantidadeCompra}"); // Exibir quantidade que sera vendido.
//  Console.WriteLine($"É possível realizar a venda? {possivelVenda}"); // Verificar estoque para possivel venda.

//  if(quantidadeCompra == 0)
// {
//      Console.WriteLine("Venda invalida");
//      Console.Read);
// }

//  else if(possivelVenda)
// {
//      Console.WriteLine("Venda realizada"); // Caso estoque OK venda realizada.
// }
//  else
// {
//      Console.WriteLine("Desculpe. Não temos a quantidade em estoque"); // Falta produto tem estoque
// }




// string a = "15p";

// int b = 0;

// int.TryParse(a, out b);


// Console.WriteLine(b);
// Console.WriteLine("Sua conversão foi realizada com sucesso");






// int a = 5;
// double b = a;

// Console.WriteLine(b);







//Cast - Casting convertendo STRING para INT.
//int a = Convert.ToInt32 ("51");

// string a = "Anderson é gay";
// Console.WriteLine(a);





// float a = 13;
// float b = 12;

// float c = a / b;

// Console.WriteLine(c);




//c = c + 5;  = c =+ 5

// DateTime  dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);



// PARA COMENTAR CTRL + K + C

// string apresentacao = "Olá, seja bem vido";
// int quntidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valo da variavel quantiade: "+ quntidade);
// Console.WriteLine("Valo da variavel altura: "+ altura);
// Console.WriteLine("Valo da variavel preço: "+ preco);
// Console.WriteLine("Valo da variavel booleana: " + condicao);


//Pessoa P = new Pessoa();

//P.Nome = "Edson";
//P.Idade = 21;
//P.Apresentar();