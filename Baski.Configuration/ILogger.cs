using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baski.Configuration
{
    public interface ILogger
    {
        string Log(string input);
    }

    public class MyLogger : ILogger
    {
        public string Log(string input)
        {
            return input + "!!!";
        }
    }
}
