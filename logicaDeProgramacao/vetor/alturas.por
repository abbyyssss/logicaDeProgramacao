programa
{
    funcao inicio()
    {
        inteiro n
        real media_altura, soma_altura = 0.0
        inteiro cont_menor_16 = 0
        cadeia nomes_menor_16 = ""

        escreva("Quantas pessoas serao digitadas? ")
        leia(n)
 
        cadeia nomes [n]
        inteiro idades[n]
        real alturas[n]

        para(inteiro i = 0; i < n; i++){
            escreva("Dados da ", i+1, "a pessoa:\n")
            escreva("Nome: ")
            leia(nomes[i])
            escreva("Idade: ")
            leia(idades[i])
            escreva("Altura: ")
            leia(alturas[i])

            soma_altura += alturas[i]

            se(idades[i] < 16){
                cont_menor_16++
                nomes_menor_16 += nomes[i] + "\n"
            }
        }

        media_altura = soma_altura / n

        escreva("\nAltura média: ", media_altura)
        escreva("\nPessoas com menos de 16 anos: ", (cont_menor_16 / n) * 100.0, "%")
        se(nomes_menor_16 != ""){
            escreva("\n", nomes_menor_16)
        }
    }
}
