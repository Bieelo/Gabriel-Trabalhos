//Verificar sinais utilizados é sempre bom


programa
{
	
	funcao inicio()
	{
		escreva(" Escolha uma das opções: 1 - Abrir GOW 2 - Abrir Halo 3 - Abrir Forza 4 - Sair ")
	     inteiro menu=0
          escreva("\n" + " sua escolha: ")
          leia(menu) 
          
	     escolha (menu)
	     {
	     	caso 1: 
	     	escreva(" OK! Abrindo GOW ")
	     	pare

	     	caso 2: 
	     	escreva(" OK! Abrindo Halo ")
	     	pare

	     	caso 3:
	     	escreva(" OK! Abrindo Forza ")
	     	pare 

               caso 4:
               escreva(" desligando computador... ")
	     	
	     	caso contrario: escreva(" Você deve escolher algum jogo para jogar ")
	     }
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 42; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */