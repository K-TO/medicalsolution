using Newtonsoft.Json;

namespace MedicalSolution.Presentation.ErrorHandler
{
    public class ErrorDetails
    {
        public bool IsError { get; set; }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
