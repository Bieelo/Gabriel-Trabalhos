// função do algoritmo: calcular média aritmética
// Gabriel Ferreira Amorim 07/12/21
// Estudante da Etec sapopemba

programa
{
	
	funcao inicio()
	{
		real jan,fev,mar,abr,media
		cadeia funcionario

		escreva (" digite o nome do funcionario ")
		leia(funcionario)
		escreva (" numero de vendas em janeiro: ")
		leia(jan)
		escreva (" numero de vendas em fevereiro ")
		leia(fev)
		escreva (" numero de vendas em março ")
		leia(mar)
		escreva (" numero de vendas em abril ")
		leia(abr)

		media = (jan+fev+mar+abr)/4
//formula para calcula da média aritmética

		escreva (" O funcionario " + funcionario + " obteve a media " + media)
 //verifica a média aritmética do funcionario

		se(media>=6) { escreva ("\n" + " parabéns!! você foi aprovado!! ") }
//desvio condicional = se a média do funcionario for mais de 6, ele é aprovado.
		senao { escreva ("\n" + " parabéns!! você foi demitido!! ") }
//desvio condicional = condição falsa/contraria a SE.(menos de 6 é demição)	
		
		
		
		


		
		
	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 975; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */