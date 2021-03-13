using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using UserRoles.Service.Abstract;

namespace UserRoles.Service.Concrete
{
    [Serializable]
    public class ServiceResponse<T> : IServiceResponse<T>
    {
        public IList<T> List { get; set; }
        [JsonProperty]
        public T Entity { get; set; }
        public int Count { get; set ; }
        public bool IsSuccessful { get; set; }
    }
}
