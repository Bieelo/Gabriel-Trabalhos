programa
{
	
	funcao inicio()
	{
		real JAN,FEV,MAR,ABR,Media
		cadeia nome

		escreva(" Qual é seu nome? ")
		leia(nome)
		escreva(" Número de vendas em janeiro: ")
		leia(JAN)
		escreva(" Número de vendas em fevereiro: ")
		leia(FEV)
		escreva(" Número de vendas em março: ")
		leia(MAR)
		escreva(" Número de vendas em abril: ")
		leia(ABR)

		Media = (JAN+FEV+MAR+ABR)/4

		escreva( + nome + ", Sua média de vendas é de: " + Media)

		se (Media>=5) { escreva ("\n" + "Parabéns!! Você passou para a segunda etapa da programação!!")}
		senao { escreva ("\n" + "Se lascou") }

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 567; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */