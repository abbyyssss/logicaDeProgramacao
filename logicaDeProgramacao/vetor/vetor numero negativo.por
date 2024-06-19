programa
{
    funcao inicio()
    {
        inteiro n
        escreva("Quantos numeros voce vai digitar? ")
        leia(n)
        inteiro vetor[n]

        para(inteiro i = 0; i < n; i++){
            escreva("Digite um numero: ")
            leia(vetor[i])
        }

        escreva("\nNUMEROS NEGATIVOS:\n")
        para(inteiro i = 0; i < n; i++){
            se(vetor[i] < 0){
                escreva(vetor[i], "\n")
            }
        }
    }
}
