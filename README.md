![ES-4](https://github.com/user-attachments/assets/a2e54098-8641-46ca-8c71-399f54624d9f)

## 🥁 CarnaCode 2026 - Desafio 09 - Decorator

Oi, eu sou o Augusto Lima e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Decorator** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Uma cafeteria oferece bebidas base (Café, Cappuccino) e múltiplos complementos (Leite, Chocolate, Chantilly, Caramelo). O código atual cria uma classe para cada combinação possível, resultando em explosão de classes e código duplicado.

## Solução
O padrão Decorator foi aplicado para resolver os seguintes problemas:
- ✅ Como adicionar ingredientes de forma flexível e dinâmica? - Usando decoradores que podem ser combinados em tempo de execução.
- ✅ Como evitar explosão de subclasses para cada combinação de ingredientes? - Cada ingrediente é um decorator independente.
- ✅ Como manter o código aberto para extensão e fechado para modificação? - Novos ingredientes são adicionados sem alterar as classes existentes.
- ✅ Como calcular o preço e a descrição do café de forma transparente? - Cada decorator incrementa o custo e a descrição.

### Estrutura do projeto
📂 src/DecoratorChallenge/<br>
├── 📂 Component/<br>
│
└── ICoffee.cs # Interface base para cafés e decoradores<br>
├── 📂 ConcreteComponents/<br>
│
├── Espresso.cs # Café espresso<br>
│
└── Cappuccino.cs # Café cappuccino<br>
├── 📂 Decorator/<br>
│
└── CoffeeDecorator.cs # Decorator base<br>
├── 📂 ConcreteDecorators/<br>
│
├── MilkDecorator.cs # Adiciona leite<br>
│
├── ChocolateDecorator.cs # Adiciona chocolate<br>
│
├── WhippedCreamDecorator.cs # Adiciona chantilly<br>
│
└── CaramelDecorator.cs # Adiciona caramelo<br>

Program.cs # Exemplos de uso do padrão

### Componentes
#### 1. Component (ICoffee)
Define a interface comum para cafés e decoradores, com métodos para obter custo e descrição.

#### 2. ConcreteComponent (Espresso, Cappuccino)
Implementações concretas de cafés básicos, sem ingredientes adicionais.

#### 3. Decorator (CoffeeDecorator)
Classe abstrata que implementa ICoffee e armazena uma referência para outro ICoffee. Permite adicionar funcionalidades de forma transparente.

#### 4. ConcreteDecorators (MilkDecorator, ChocolateDecorator, WhippedCreamDecorator, CaramelDecorator)
Cada classe adiciona um ingrediente específico ao café, incrementando custo e descrição.

### Tecnologias
•	.NET 8
•	C# 12
•	Design Pattern: Decorator

### Como Executar
1. Clone o repositório
2. Navegue até a pasta do projeto:
```bash
cd DecoratorChallenge
```
3. Execute o projeto:
```bash
dotnet run
```

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
