using Confluent.Kafka;

var config = new ProducerConfig()
{
    BootstrapServers = "localhost:9094",
    //ClientId = Dns.GetHostName()
};

Console.WriteLine("Введите сообщение: ");


using (var producer = new ProducerBuilder<Null, string>(config).Build())
{
    while (true)
    {
        var input = Console.ReadLine();
        producer.Produce("registrations", new Message<Null, string>() { Value = input });
    }
}