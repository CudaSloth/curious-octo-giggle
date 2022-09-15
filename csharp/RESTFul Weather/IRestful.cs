using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFul_Weather
{
    internal interface IRestful
    {
        void Get();
        void Put();
        void Delete();
        void Post();        
    }
}
