
# Logonaut

**Logonaut** é um sistema distribuído para centralização de logs, projetado com escalabilidade, resiliência e desacoplamento em mente. Utiliza o padrão **Outbox**, **RabbitMQ** como broker de mensagens e **Elasticsearch** para indexação e consulta dos logs.

> O objetivo é permitir que múltiplos serviços publiquem logs de forma confiável, mesmo em ambientes instáveis, mantendo rastreabilidade e performance.

---

## Arquitetura
[FigJam](https://www.figma.com/board/uLEZwd34J3vmBmSNQjT7fC/Logonaut?node-id=0-1&p=f&t=r1m3FyeoABqcFyUh-0)

---

## Tecnologias

- [.NET 8 / 9](https://dotnet.microsoft.com/)
- [MassTransit](https://masstransit.io/) + [RabbitMQ](https://www.rabbitmq.com/)
- [MongoDB](https://www.mongodb.com/) (Outbox Pattern)
- [Elasticsearch](https://www.elastic.co/) + [Kibana](https://www.elastic.co/kibana)
- [Docker Compose](https://docs.docker.com/compose/)

---

## Como rodar localmente

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/logonaut.git
cd logonaut
```
2. Suba os serviços com Docker:
```bash
docker-compose up -d
```
3. Acesse:
- RabbitMQ Management UI: http://localhost:15672 (guest/guest)
- Kibana: http://localhost:5601
- Mongo Express (opcional) ou pode-se utilizar o MongoDb Compass: http://localhost:8081

## Estrutura do Projeto

| Pasta/Projeto | Descrição
|-|-|
|Logonaut.Producer.* | Aplicações produtoras que geram logs e escrevem em suas collections de Outbox
|Logonaut.OutboxReader | Leitor de Outboxes que publica no RabbitMQ com base em config dinâmica
|Logonaut.Consumer | Consumidor MassTransit que recebe e envia para Elasticsearch
|docker-compose.yml | Orquestra Mongo, RabbitMQ, Elasticsearch e Kibana

## Exemplo de documento Outbox

```json
OutboxLogs_Example

{
  "_id": ObjectId,
  "payload": {
    "ExampleId": 1,
    "StartProcess": "2025-04-18T12:33:33.999",
    "EndedProcess": "2025-04-18T12:33:35.999"
  },
  "level": "INFORMATION",
  "message": "Example has been processed.",
  "createdAt": "2025-04-18T12:33:34.777",
  "processed": false
}
```

## Roadmap
- [x] Estrutura básica com RabbitMQ e MongoDB
- [ ] Retry e dead-letter queue
- [ ] Logs com enriquecimento automático (TraceId, Tags)
- [ ] Painel de métricas com Prometheus + Grafana


  


