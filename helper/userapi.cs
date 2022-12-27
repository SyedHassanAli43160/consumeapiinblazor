namespace consumeapiinblazor.helper
{
    public class userapi
    {
        public HttpClient initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://test.crudapi.com/");
            return client;
        }
    }
}
