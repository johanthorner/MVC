using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie_Lab3_upg2.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
