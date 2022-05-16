using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxsoft
{
    public interface IDataProcessor
    {
        string GetBinary(string inputData, string dataType);
        string GetText(string inputData, string dataType);
        string GetReverseText(string inputData, string dataType);
    }
}
