using Azure;
using Azure.Messaging.EventGrid;

string topicEndpoint = "<event grid topic endpoint>";
string topicAccessKey = "<event grid topic key>";

EventGridPublisherClient client = new EventGridPublisherClient(
    new Uri(topicEndpoint),
    new AzureKeyCredential(topicAccessKey));

EventGridEvent egEvent =
    new EventGridEvent(
        "ExampleEventSubject",
        "Example.CarPurchased",
        "1.0",
        "Hi Everyone!");

// Send the event
await client.SendEventAsync(egEvent);