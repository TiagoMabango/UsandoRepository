namespace Xyami.API.Helpers
{
    public class Response
    {
        public bool Status { get; set; }
        public string Message { get; set; } 
        public object Object { get; set; }
        public Response Good(string msg, object obj = null)
        {
            Status = true;
            Message = msg;
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }
        public Response ErrorResponse(string msg)
        {
            Status = false;
            Message = msg;
            return this;

        }
        public Response Bad(string msg, object obj = null)
        {
            Status = false;
            Message = msg;
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }

        public Response Good(object obj)
        {
            Status = true;
            Message = "Operação realizada com exito";
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }

        public Response Bad(object obj)
        {
            Status = false;
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }
    }
}
