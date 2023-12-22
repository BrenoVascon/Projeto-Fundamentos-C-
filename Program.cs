using C_.Models;
using EstudosC.Models; 


List<string> listaString = new List<string>();


listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");





for(int contador = 0; contador < listaString.Count; contador++){
        Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}



int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição N°{contadorForeach} - {item}");
    contadorForeach++;
}





// int [] arrayInteiro = new int [3]; 
// arrayInteiro[0] = 72;
// arrayInteiro[1] = 64;
// arrayInteiro[2] = 50; 



// int [] ArrayInteirosDobrados = new int [arrayInteiro.Length * 2];
// Array.Copy(arrayInteiro, ArrayInteirosDobrados, arrayInteiro.Length);

// // Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);

// for (int contador = 0; contador < arrayInteiro.Length; contador++)
// {
//         Console.WriteLine($"Posição N° {contador} - {arrayInteiro[contador]}");
// };

















// Console.WriteLine("Percorrendo o ForEach");

// int contadorForeach= 0; 
// foreach (int valor in arrayInteiro)
// {
//         Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//         contadorForeach++;
// }














// string opção;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//         Console.Clear();
// Console.WriteLine("Selecione uma opção:");
// Console.WriteLine("1 - Cadastrar cliente: ");
// Console.WriteLine("2 - Buscar cliente: ");
// Console.WriteLine("3 - Apagar cliente:");
// Console.WriteLine("4 - Encerrar: ");

// opção = Console.ReadLine();
// switch(opção){
//         case "1" :
//         Console.WriteLine("Cadastro de cleinte");
//         break;

//         case "2" :
//         Console.WriteLine("Buscar cliente");
//         break;

//         case "3" :
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4" :
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//         break;

//         default: 
//          Console.WriteLine("Opção Invalida");
//         break;
// }
// }














// DO WHILE
// int soma = 0, numero = 0;

// do
// {
// Console.WriteLine("Digite um Numero(Zero para parar)");
// numero = Convert.ToInt32(Console.ReadLine());

// soma += numero;
// }while(numero != 0);

// //$ Coloque para misturar variavel com string
// Console.WriteLine($"Total da soma dos numeros digitados é:{soma}");






















// int contador = 1;
// int numero = 5;

// while(contador <= 10)
// {
//   Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//   contador++;

//  if(contador == 6)
//  {
//          break;
//  }
// }


//FOR
// int numero = 10;
// for(int contador = 0; contador <= 10; contador++)
// {
// Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// Calculadora calc = new Calculadora();

// calc.Somar(15, 8);
// calc.Subtrair(20, 5);
// calc.Dividir(15, 3);
// calc.Multiplicar(3, 10);
// calc.potencia(4, 4);


// int numeroIncremento = 10;

// Console.WriteLine ("Incrementando o 10");
// numeroIncremento++ ;
// Console.WriteLine(numeroIncremento);

// Exemplo do operador NOT (!)

// bool choveu = false;
// bool estaTarde = false;

// Verifica se a permissão NÃO está presente
// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou Pedalar.");
// }
// else
// {
// }





// Operador && 

// bool possuiPresencaMinima = true;
// double media = 7.5; 

// if (possuiPresencaMinima && media >= 7)
// {
//    Console.WriteLine("Aprovado!");
// } 
// else {
//   Console.WriteLine("Reprovado!");
// }






// OPERADOR PIPE   || 


// bool ehMaiorDeIdade = true; 
// bool possuiAutorizacaoDoResponsavel = false; 

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel ){
//   Console.WriteLine("Entrada Liberada");
// }
// else{
//   Console.WriteLine("Entrada não liberada");
// }







// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));








// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M; //é mais preciso, trabalha com casas decimais depois da virgula

// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura);
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome="Buta";
// pessoa1.Idade= 26;

// pessoa1.Apresentar();




// using EstudosC.Models; 

// int quantidadeEmpresa = 10;
// int quantidadeProduto = 4;
// bool possivelVenda = quantidadeEmpresa > 0 && quantidadeEmpresa >= quantidadeProduto; 

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmpresa}");
// Console.WriteLine($"Quantidade compra: {quantidadeProduto}");
// Console.WriteLine($"è possivel realizar a venda? {possivelVenda}");

// if(quantidadeProduto == 0) {
//   Console.WriteLine("Venda inválida");
// }
// if(possivelVenda)
//  {
//   Console.WriteLine("Venda realizada");
// }
// else
// {
// Console.WriteLine("Desculpe. não temos a quantidade necessaria no estoque");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u": 
//   Console.WriteLine("Vogal");
//   break;
//   default: 
//   Console.WriteLine("não é uma vogal");
//     break;
// }