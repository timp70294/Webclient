using System.Net;

HttpClient client = new HttpClient();
HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "http://localhost:9191");

//client.DefaultRequestHeaders.Add("Accept", "application/json");

HttpResponseMessage response = await client.SendAsync(message).ConfigureAwait(false);

string context = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

Console.WriteLine(context);

Console.WriteLine(response.StatusCode);
Console.WriteLine(response); 
