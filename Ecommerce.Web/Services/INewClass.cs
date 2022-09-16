using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Web.Services
{
    public interface INewClass
    {
        Task<List<string>> GetString();
        List<string> StringList{get; set;}
    }
}