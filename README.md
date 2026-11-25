# Calculadora de Console em C#

Meu primeiro projeto em C#: uma calculadora que roda no terminal, feita para praticar os fundamentos da linguagem.

## O que ela faz

- Pede dois números e uma operação
- Calcula e mostra o resultado
- Permite fazer várias contas seguidas sem fechar o programa
- Mostra um histórico de todas as contas ao final
- Valida a entrada: se você digitar letras no lugar de números, ele pergunta de novo
- Trata erros comuns, como divisão por zero e raiz quadrada de número negativo

## Operações disponíveis

| Símbolo | Operação |
|---------|----------|
| `+` | Soma |
| `-` | Subtração |
| `*` | Multiplicação |
| `/` | Divisão |
| `^` | Potência (primeiro número elevado ao segundo) |
| `r` | Raiz quadrada (usa apenas o primeiro número) |

## Como executar

Pré-requisito: ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```
git clone https://github.com/SEU-USUARIO/MeuPrimeiroProjeto.git
cd MeuPrimeiroProjeto
dotnet run
```

> Troque `SEU-USUARIO` pelo seu nome de usuário no GitHub.

## Exemplo de uso

```
Digite o primeiro número:
10
Digite o segundo número:
4
Escolha a operação (+, -, *, /, ^ para potência, r para raiz do primeiro número):
/
Resultado: 2,5
Deseja fazer outra conta? (s/n)
n

Histórico de contas:
10 / 4 = 2,5
Até logo!
```

## Conceitos praticados

- Entrada e saída no console (`Console.ReadLine` e `Console.WriteLine`)
- Variáveis e tipos (`string`, `double`, `bool`)
- Decisões com `if / else` e `switch`
- Laços com `while` e `foreach`
- Métodos com parâmetros e retorno
- Validação de entrada com `double.TryParse`
- Listas com `List<string>`
- Funções matemáticas com a classe `Math`

## Possíveis melhorias futuras

- Salvar o histórico em um arquivo de texto
- Adicionar porcentagem e outras operações
- Melhorar a exibição da raiz quadrada no histórico
- Criar testes automatizados

## Tecnologias

- C#
- .NET
- Visual Studio Code