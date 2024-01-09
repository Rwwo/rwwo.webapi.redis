# Caching in .NET Core usando Redis

## O que � Caching?
Caching � uma t�cnica que permite aos desenvolvedores armazenar e recuperar dados ou c�lculos mais frequentemente utilizados de maneira eficiente, 
reduzindo assim a necessidade de recriar ou buscar a mesma informa��o repetidamente.

* Em mem�ria: Consiste em armazenar dados diretamente no espa�o de mem�ria do servidor de uma aplica��o.
* Distribu�do: Basicamente, os dados s�o armazenados e compartilhados entre v�rios servidores.

## Sobre o Redis
Redis (Remote Dictionary Server) � um sistema de armazenamento de dados em mem�ria open-source que pode ser utilizado como cache, message broker (corretor de mensagens) 
e banco de dados chave-valor. � conhecido por sua alta performance, versatilidade e suporte a uma ampla gama de estruturas de dados. O Redis foi projetado para ser r�pido,
escal�vel e confi�vel, tornando-se uma escolha popular para o desenvolvimento de aplica��es em tempo real.
 

## Sobre o Projeto

1 - Rodar o redis

```
docker run --name redis -d -p 6379:6379 redis:latest
```

2 - Desenvolver a API

3 - Adicionar a conex�o do redis no appsetting.json
```
  "ConnectionStrings": {
    "default": "connectionstring"
    "Redis": "localhost"
  }
```

4 - Adicionar as DI.



![Api](./Images/Swagger.png)

###

![Cache no Redis - Item Armazenado](./Images/RedisCache.png)


###

> [!NOTE]
> Projeto desenvolvido para fins de estudos.
