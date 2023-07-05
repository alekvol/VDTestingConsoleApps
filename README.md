# VDTestingConsoleApps
Тестовая работа с консольными приложениями и Kafka
## Перед запуском

#### Создайте Kafka контейнер
```docker
docker run -d --name kafka -p 9092:9092 -p 9094:9094
-e ALLOW_PLAINTEXT_LISTENER=yes
-e KAFKA_CFG_LISTENERS=PLAINTEXT://:9092,CONTROLLER://:9093,EXTERNAL://:9094
-e KAFKA_CFG_ADVERTISED_LISTENERS=PLAINTEXT://kafka:9092,EXTERNAL://localhost:9094
-e KAFKA_CFG_LISTENER_SECURITY_PROTOCOL_MAP=CONTROLLER:PLAINTEXT,EXTERNAL:PLAINTEXT,PLAINTEXT:PLAINTEXT
-e KAFKA_CFG_AUTO_CREATE_TOPICS_ENABLE=false
bitnami/kafka:latest
```
#### Создайте топик 
```
kafka-topics.sh --list --bootstrap-server localhost:9094
```
#### Настройте запуск проектов в VS, чтобы запускались два консольных приложения одновременно

***Enjoy!!!***
