
# Logonaut

**Logonaut** é um sistema distribuído para centralização de logs, projetado com escalabilidade, resiliência e desacoplamento em mente. Utiliza o padrão **Outbox**, **RabbitMQ** como broker de mensagens e **Elasticsearch** para indexação e consulta dos logs.

> O objetivo é permitir que múltiplos serviços publiquem logs de forma confiável, mesmo em ambientes instáveis, mantendo rastreabilidade e performance.

---

## Arquitetura
[FigJam](https://www.figma.com/board/uLEZwd34J3vmBmSNQjT7fC/Logonaut?node-id=0-1&p=f&t=r1m3FyeoABqcFyUh-0)

---

## 🧰 Tecnologias

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
- Mongo Express (opcional): http://localhost:8081

## Roadmap
- [x] Estrutura básica com RabbitMQ e MongoDB
- [ ] Retry e dead-letter queue
- [ ] Logs com enriquecimento automático (TraceId, Tags)
- [ ] Painel de métricas com Prometheus + Grafana


  


