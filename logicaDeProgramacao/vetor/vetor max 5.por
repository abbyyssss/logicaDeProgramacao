programa {
  funcao inicio() {
    inteiro n1, contador
    inteiro vetor[5]
    escreva("Quantos números você deseja digitar (máximo 5): ")
    leia(n1)
 
    para (contador = 0; contador < n1; contador++) {
      escreva("Digite um número: ")
      leia(vetor[contador])
    }
 
    para (contador = 0; contador < n1; contador++) {
      escreva("A posição ", contador, " é: ", vetor[contador], "\n")
    }
  }
}
 