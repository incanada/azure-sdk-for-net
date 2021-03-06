## Working with transactions

This sample demonstrates how to use [transactions](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-transactions) with Service Bus. Transactions allow you to group operations together so that either all of them complete or none of them do. If any part of the transaction fails, the service will rollback the parts that succeeded on your behalf. You also can use familiar .NET semantics to complete or rollback the transaction using [TransactionScope](https://docs.microsoft.com/en-us/dotnet/api/system.transactions.transactionscope?view=netcore-3.1).

### Sending and completing a message in a transaction on the same entity

```C# Snippet:ServiceBusTransactionalSend
string connectionString = "<connection_string>";
string queueName = "<queue_name>";
// since ServiceBusClient implements IAsyncDisposable we create it with "await using"
await using var client = new ServiceBusClient(connectionString);
ServiceBusSender sender = client.CreateSender(queueName);

await sender.SendAsync(new ServiceBusMessage(Encoding.UTF8.GetBytes("First")));
ServiceBusReceiver receiver = client.CreateReceiver(queueName);
ServiceBusReceivedMessage firstMessage = await receiver.ReceiveAsync();
using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
{
    await sender.SendAsync(new ServiceBusMessage(Encoding.UTF8.GetBytes("Second")));
    await receiver.CompleteAsync(firstMessage);
    ts.Complete();
}
```

### Sending and completing a message in a transaction across two entities
There may be cases where you want to involve multiple entities in a single transaction. Service Bus offers support for this if your transaction involves sending to one entity and settling on a different entity. In order to accomplish this, you would use the send-via feature to route your message through the entity that you wish to settle a message on. The transaction will occur on that entity, and then Service Bus will forward the message onto its final destination.

```C# Snippet:ServiceBusTransactionalSendVia
string connectionString = "<connection_string>";
string queueA = "<queue_name>";
string queueB = "<other_queue_name>";
// since ServiceBusClient implements IAsyncDisposable we create it with "await using"
await using var client = new ServiceBusClient(connectionString);

ServiceBusSender senderA = client.CreateSender(queueA);
await senderA.SendAsync(new ServiceBusMessage(Encoding.UTF8.GetBytes("First")));

ServiceBusSender senderBViaA = client.CreateSender(queueB, new ServiceBusSenderOptions
{
    ViaQueueOrTopicName = queueA
});

ServiceBusReceiver receiverA = client.CreateReceiver(queueA);
ServiceBusReceivedMessage firstMessage = await receiverA.ReceiveAsync();
using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
{
    await receiverA.CompleteAsync(firstMessage);
    await senderBViaA.SendAsync(new ServiceBusMessage(Encoding.UTF8.GetBytes("Second")));
    ts.Complete();
}
```

## Source

To see the full example source, see:

* [Sample06_Transactions.cs](../tests/Samples/Sample06_Transactions.cs)
