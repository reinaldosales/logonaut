
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
- [PostgreSql](https://www.postgresql.org/) (Outbox Pattern)
- [Elasticsearch](https://www.elastic.co/) + [Kibana](https://www.elastic.co/kibana)
- [Docker Compose](https://docs.docker.com/compose/)

---

## Como rodar localmente

1. Clone o repositório:
```bash
git clone https://github.com/reinaldosales/logonaut.git
cd logonaut
```
2. Suba os serviços com Docker:
```bash
docker-compose -f .\docker-composer.yaml up
```
3. Para os acessos:
- RabbitMQ Management UI: http://localhost:15672 (guest/guest)
- Kibana: http://localhost:5601 (elastic/kibana)
- Azure Data Studio (PostgreSql)

## Estrutura do Projeto

| Pasta/Projeto | Descrição
|-|-|
|Logonaut.Producer.* | Aplicações produtoras que geram logs e escrevem em suas collections de Outbox
|Logonaut.OutboxReader | Leitor de Outboxes que publica no RabbitMQ com base em config dinâmica
|Logonaut.Consumer | Consumidor MassTransit que recebe e envia para Elasticsearch
|docker-compose.yml | Orquestra Postgres, RabbitMQ, Elasticsearch e Kibana

## Exemplo de entidade Outbox no Postgres
outbox_log
|property|type|
|-|-|
|id| uuid primary key|
|source_app| uuid not null|
|payload | jsonb not null|
|created_at|timestamptz DEFAULT now()|
|processed| boolean default false|
|processed_at|timestamptz|

source_app
|property|type|
|-|-|
|id| serial primary key|
|name| text unique not null|
|enabled| boolean default false|
|created_at| timespamtz not null|

## Roadmap
- [x] Estrutura básica com RabbitMQ e Postgres
- [ ] Retry e dead-letter queue
- [ ] Logs com enriquecimento automático (TraceId, Tags)
- [ ] Painel de métricas com Prometheus + Grafana


  


