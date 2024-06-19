programa
{
	funcao inicio()
	{
		inteiro n
		escreva("Quantos numeros voce vai digitar? ")
		leia(n)

		inteiro vetor[n], i
		inteiro soma = 0

		para(i = 0; i < n; i++){
			escreva("Digite um numero: ")
			leia(vetor[i])
			soma = soma + vetor[i]
		}

		escreva("VALORES = ")
		para(i = 0; i < n; i++){
			escreva(vetor[i], " ")
		}

		real media = soma / n

		escreva("\nSOMA = ", soma)
		escreva("\nMEDIA = ", media)
	}
}
