using System.Text.Json.Nodes;

namespace API.RequestHandling
{
    public class RequestReturn<T>
    {
        public T? Object { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public bool Error { get; set; }

        public string? Exception { get; set; }

        public RequestReturn(int Status = 200, bool Error = false,string Message = "")
        {
            this.Status = Status;
            this.Error = Error;
            this.Message = Message;
        }

        public void Update (int Status = 200, bool Error = false, string Message = "")
        {
            this.Status = Status;
            this.Error = Error;
            this.Message = Message;
        }

        public void HandleException(Exception Exception)
        {
            this.Status = 500;
            this.Error = true;
            this.Message = Exception.Message;

            
            this.Exception = Exception.InnerException != null? Exception.InnerException.ToString() : "";


        }
    }
}
