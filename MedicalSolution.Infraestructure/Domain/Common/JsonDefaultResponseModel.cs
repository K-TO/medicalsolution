namespace MedicalSolution.Infraestructure.Domain.Common
{
    public class JsonDefaultResponseModel
    {
        public bool IsError { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
