

namespace MyNameSpace.Asynchronous
{
    class AsynchronousClass
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public async Task GetJsonData()
        {
            // getting fake data from https://jsonplaceholder.typicode.com
            string response = await _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
            System.Console.WriteLine(response);
        }

    }
}