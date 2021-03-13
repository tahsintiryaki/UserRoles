using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Service.Abstract
{
  
    public interface IServiceResponse<T>
    {
        IList<T> List { get; set; }
        T Entity { get; set; }
        int Count { get; set; }
        bool IsSuccessful { get; set; }
    }
}
