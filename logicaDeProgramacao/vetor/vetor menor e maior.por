programa
{
    
    funcao inicio()
    {
        real qtdElementos, v[100], maiorElemento = 0.0, posicaoElemento = 0.0, contador = 0.0

        v[0] = 0.0
        escreva("Quantos números você vai digitar? ")
        leia(qtdElementos)
            
        para(inteiro a = 1; a <= qtdElementos; a++){
            escreva("Digite um número: ")
            leia(v[a])
            
            maiorElemento = v[0]
        
            para(inteiro b = 1; b <= qtdElementos; b++){
                se(v[b] > maiorElemento){
                    maiorElemento = v[b]
                    contador++
                }
                
            }
            
        }
    
        escreva("MAIOR VALOR: ", maiorElemento) 
        escreva("\nPOSIÇÃO DO MAIOR VALOR: ", contador) 
    }
}
