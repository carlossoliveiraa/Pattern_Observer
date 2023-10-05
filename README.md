# Padrão Observer em C#
Resumo
O Padrão Observer é um padrão de design comportamental em C# que permite estabelecer relações de dependência dinâmica entre objetos. Ele é usado quando um objeto (o "sujeito") precisa notificar automaticamente outros objetos dependentes (os "observadores") sobre mudanças em seu estado.

# Como Funciona
Sujeito: O objeto que é observado e possui informações que podem mudar ao longo do tempo.

Observadores: Os objetos que desejam ser notificados sobre as mudanças no sujeito.

Quando o sujeito sofre uma mudança de estado, ele notifica todos os observadores registrados. Os observadores podem então reagir a essas mudanças de maneira automática.

# Implementação em C#
O Padrão Observer pode ser implementado em C# usando recursos como:

Delegados e Eventos: Utilize eventos para permitir que os observadores se inscrevam e recebam notificações quando ocorrem mudanças no sujeito.

System.Reactive (Rx): Faça uso da biblioteca System.Reactive (Reactive Extensions) para criar observáveis e observadores de maneira mais eficiente, oferecendo recursos adicionais para manipulação de fluxos de eventos.

# Benefícios
Desacoplamento: O Padrão Observer ajuda a manter baixo acoplamento entre o sujeito e os observadores, permitindo que eles evoluam independentemente.

Flexibilidade: Adicionar ou remover observadores é fácil, permitindo alterações dinâmicas na quantidade e tipo de observadores.

# Material de Apoio

https://www.youtube.com/watch?v=ZoqKXvu8u_Y&t=562s
