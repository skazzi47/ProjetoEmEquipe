# ProjetoEmEquipe

## 1. Calculadora Simples
Feito por: Guilherme Mauricio de Oliveira Damasceno

Codigo básico usando os comandos `ConsoleKeyInfo` e `Console.ReadKey` do C# para realizar operações matemáticas básicas.

### O que foi utilizado
Biblioteca `System`, Comando `ConsoleKeyInfo`, Comando `Console.ReadKey`, Estruturas de comparação e Interpolação de variáveis.

### Etapas implementadas
- [x] Solicitar ao usuário para informar 2 números para que eles sejam usados na operação matemática que o usuário selecionar.
- [x] Solicitar ao usuário para escolher uma operação matemática apertando as seguintes teclas: "A" para Adição, "S" para Subtração, "M" para Multiplicação e "D" para Divisão.
- [x] Fazer a leitura da tecla que o usuário apertou.
- [x] Se o usuário tiver apertado alguma das teclas informadas à frente: "A", "S", "M" ou "D", realizar a operação matemática correspondente com os 2 números que o usuário informou.
- [x] Caso o usuário não tenha apertado alguma das 4 teclas citadas acima, pedir que ele aperte novamente alguma das teclas pedidas.
- [x] Retornar ao usuário o valor da operação matemática realizada pelo código.

### Backlog
- [ ] Realizar operações matemáticas.

### Conclusão
Geralmente quando iria fazer estruturas condicionais em códigos de qualquer natureza sempre selecionávamos o que queriamos fazer escrevendo alguma letra no CMD e apertávamos enter, porém eu quis fazer algo mais complexo e interessante, assim veio a ideia de selecionar opções no código apenas apertando uma determinada tecla seja ela qual for, assim fiz esse código usando os comandos "ConsoleKeyInfo" e "Console.ReadKey" para que eles identifiquem quando a tecla desejada for pressionada e realize determinada ação dentro do código.

---

## 2. Jogo de Adivinhação de Números
Feito por: Ykaro Kaynã Dias Ribeiro

---

## 3. Gerador de Senhas Aleatórias
Feito por: Lígia Morais de Souza

---

## 4. Conversor de Temperatura
Feito por: Luiz Otávio Ferreira da Silva

### O que foi utilizado
Biblioteca `System` e estruturas de decisão para contorno de input inválido e impressão do resultado da conversão em console.

### O que foi utilizado
- **Linguagem de Programação:** C#
- **Framework:** .NET
- **Versionamento:** GIT
- **Gestão de Repositórios:** GitHub

- [x] Solicitar que o usuário insira o valor a ser convertido.
- [x] Mensagem de erro para input inválido do usuário.
- [x] Escolha do tipo de conversão: Após inserir o valor a ser convertido, o usuário decide o tipo de conversão a ser realizada.
- [x] Impressão do resultado em console.

---

## 5. Simulador de Lançamento de Dados
Feito por: Ana Caroline Maia Duarte

### O que foi utilizado
- **Linguagem de Programação:** C#
- **Framework:** .NET
- **Versionamento:** GIT
- **Gestão de Repositórios:** GitHub

### Etapas implementadas
- [x] Gerador de números aleatórios para simular o lançamento de um dado.
- [x] Loop para permitir que o usuário jogue o dado repetidamente, com validação para respostas e opção para encerrar a aplicação.

### Backlog
- [ ] Exibir o histórico de resultados dos lançamentos.
- [ ] Jogar com dados de diferentes números de faces.

### Conclusão
Este simulador oferece uma forma descomplicada de jogar dados, permitindo que o usuário experimente a aleatoriedade em cada lançamento. A simplicidade do código torna-o fácil de entender e expandir, proporcionando uma base sólida para futuras melhorias e funcionalidades.

---

## 6. Calculadora de IMC
Feito por: Luiz Otávio Ferreira da Silva

### O que foi utilizado
Biblioteca `System` e estruturas de decisão para contorno de input inválido e impressão do resultado do cálculo em console.

### O que foi utilizado
- **Linguagem de Programação:** C#
- **Framework:** .NET
- **Versionamento:** GIT
- **Gestão de Repositórios:** GitHub

- [x] Solicitar ao usuário dois valores para o cálculo matemático.
- [x] Mensagem de erro para input inválido do usuário.
- [x] Impressão do resultado em console.

---

## 7. Decisão de Almoço
Feito por: Ana Caroline Maia Duarte

### O que foi utilizado
- **Linguagem de Programação:** C#
- **Framework:** .NET
- **Versionamento:** GIT
- **Gestão de Repositórios:** GitHub

### Etapas implementadas
- [x] Estruturas de dados para armazenar opções de restaurantes e seus pratos correspondentes.
- [x] Menu de opções:
    - [x] *Escolher restaurante*: O usuário escolhe um restaurante e, em seguida, escolhe um prato daquele restaurante.
    - [x] *Escolher prato*: O usuário escolhe um prato único, e o programa lista os restaurantes que oferecem esse prato.
    - [x] *Estou indeciso(a), escolha por mim*: O programa escolhe aleatoriamente um restaurante e um prato para o usuário.
- [x] Loop para permitir que o usuário faça novas escolhas, com validação para respostas e opção para encerrar a aplicação.

### Backlog
- [ ] Adicionar opções de filtro para restaurantes e pratos.
- [ ] Permitir ao usuário adicionar seus próprios restaurantes e pratos.
- [ ] Implementar uma funcionalidade de avaliação para restaurantes e pratos.

### Conclusão
Este aplicativo foi desenvolvido para simplificar a escolha de refeições, especialmente em momentos de indecisão. O objetivo é possibilitar os usuários a explorarem diferentes opções de restaurantes e pratos. Com sugestões aleatórias, o aplicativo ainda oferece uma alternativa interessante para quem não sabe o que escolher.

---

## 8. Cronômetro Simples
Feito por: Guilherme Mauricio de Oliveira Damasceno

### O que foi utilizado:
- Linguagem de Programação:  ``C#``
- Biblioteca ``System.Diagnostics``
- Comando ``Stopwatch stopwatch = new stopwatch();``
- Comando ``stopwatch.Start();``
- Comando ``stopwatch.Stop();``
- Comando ``TimeSpan tempoDecorrido = stopwatch.Elapsed;``

### Etapas implementadas:
- [x] Chamar o comando ``Stopwatch`` para medir o tempo decorrido de maneira precisa.
- [x] Pedir para o usuário pressionar a tecla ``ENTER`` para que o cronômetro comece a contar o tempo.
- [x] Pedir para o usuário pressionar a tecla ``ENTER`` para que o cronômetro pare de contar o tempo.
- [x] Chamar o comando ``TimeSpan tempoDecorrido = stopwatch.Elapsed;`` que fará a função de registrar oo tempo passado durante o funcionamento do cronômetro.
- [x] Informar ao usuário quanto tempo o cronômetro registrou.

### Backlog:
- [x] Pressionar a tecla ``ENTER`` para começar a cronometrar
- [x] Pressionar a tecla ``ENTER`` para parar a cronometrar
- [x] Informar o tempo passado nesse processo.

### Conclusão:
Este código foi feito para fazer a função de um cronômetro e registrar quanto tempo se passou desde sua ativação até seu desligamento por parte do usuário ao qual o está utilizando.