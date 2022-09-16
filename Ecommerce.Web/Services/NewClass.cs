using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Ecommerce.Web.Services
{
    public class NewClass : INewClass
    {
        public List<string> StringList { get; set; } = new List<string>();

        private readonly HttpClient _httpClient;
        public NewClass(HttpClient httpClient)
        {
            _httpClient = httpClient;
            
        }
        public async Task<List<string>> GetString()
        {
            StringList = await _httpClient.GetFromJsonAsync<List<string>>("api/NewApi");
            if (StringList == null)
            {
                StringList = new List<string>{"StringList couldnt fetched from Api", "StringList couldnt fetched from Api", "StringList couldnt fetched from Api"};
                return StringList;  
            }      
            return StringList;
        }
    }
}