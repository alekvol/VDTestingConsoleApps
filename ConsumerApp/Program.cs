using Confluent.Kafka;

var config = new ConsumerConfig()
{
    BootstrapServers = "localhost:9094",
    GroupId = "Consumer",
    EnableAutoCommit = false,
};

using (var consumer = new ConsumerBuilder<string, string>(config).Build())
{
    consumer.Subscribe("registrations");

    while (true)
    {
        var consumeResult = consumer.Consume();
        Console.WriteLine(consumeResult.Message.Value);
        consumer.Commit();
    }
}