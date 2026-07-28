namespace API.Utils
{
    public class RequestReturn<T>
    {
        public T Object { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
    }
}
