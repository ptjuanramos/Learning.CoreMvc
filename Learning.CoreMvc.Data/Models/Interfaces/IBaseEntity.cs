using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.CoreMvc.Data.Models.Interfaces
{
    public interface IBaseEntity<T>
    {
        T Id{ get; set; }
    }
}
