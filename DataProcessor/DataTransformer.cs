using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxsoft
{
    public abstract class DataTransformer : IDataProcessor
    {
        public string GetBinary(string inputData, string dataType)
        {
            string returnData = string.Empty;
            byte[] bytes = Encoding.UTF8.GetBytes(inputData);
            return returnData = Convert.ToBase64String(bytes).Substring(0, 5);
        }

        public string GetText(string inputData, string dataType)
        {
            string returnData = string.Empty;
            byte[] bytes = Encoding.UTF8.GetBytes(inputData);
            return returnData = Encoding.UTF8.GetString(bytes).Substring(0, 7);
        }

        public string GetReverseText(string inputData, string dataType)
        {
            string returnData = string.Empty;
            byte[] bytes = Encoding.UTF8.GetBytes(inputData);
            return returnData = new string(Encoding.UTF8.GetString(bytes).Substring(0, 6).Reverse().ToArray());
        }
    }
}
