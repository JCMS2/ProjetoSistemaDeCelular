Esse sistema simula o funcionamento básico de smartphones, permitindo realizar ações como fazer ligações, receber chamadas e instalar aplicativos. Tudo isso com base em uma estrutura bem organizada de classes.



 O que o sistema faz?
A ideia é representar dois tipos diferentes de smartphones — Nokia e iPhone — e permitir que eles executem ações básicas, como:

 Fazer ligações (Ligar)
 Receber ligações (ReceberLigacao)
 Instalar aplicativos (com mensagens diferentes para cada marca)
Esses smartphones são objetos criados a partir de classes que herdam de uma classe abstrata base, chamada Smartphone.



Como funciona?
A classe Smartphone define o que todos os celulares devem ter:

Número
Modelo
IMEI
Memória
Métodos para ligar, receber ligações e instalar aplicativos (o último é abstrato)
Depois, temos as classes Nokia e Iphone, que herdam da classe base e implementam o método InstalarAplicativo de forma personalizada — só pra deixar mais realista e mostrar como o polimorfismo funciona em C#.



O que aprendi com esse projeto
Mesmo sendo simples, esse projeto foi ótimo pra praticar:

 Herança entre classes
 Criação e uso de classes abstratas
 Polimorfismo com métodos sobrescritos (override)
 Encapsulamento, usando propriedades públicas e privadas
 Organização de código em pastas e namespaces
Além disso, ajudou bastante a visualizar como essas ideias podem ser aplicadas em projetos maiores no futuro.
