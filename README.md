## Gateway Server & APIs

Esse projeto tem como intuito criar um gateway de pagamentos.

O projeto foi dividido em duas aplicações:

Na pasta GatewayServer está a aplicação referente ao gateway.
Nela o usuário pode efetuar seu cadastro e efetuar chamadas as APIs de pagamento e segurança.

Na pasta ThreeAPIs encontram-se "mocks" dos serviços das APIs da Cielo, Stone e Clear.
Essa solução simula alguns serviços das 3 APIs citadas acima.


Para rodar qualquer uma das aplicações basta acessar o diretório raíz do respectivo projeto via terminal e digitar o comando:
```
dotnet run
```