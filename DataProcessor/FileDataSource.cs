using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxsoft
{
    public class FileDataSource : DataTransformer
    {
        public string GetData(string inputData, string datatType)
        {
            string returnData = string.Empty;
            if (datatType.ToLower() == "binary")
                returnData = base.GetBinary(inputData, datatType);
            if (datatType.ToLower() == "text")
                returnData = base.GetText(inputData, datatType);
            if (datatType.ToLower() == "reverse")
                returnData = base.GetReverseText(inputData, datatType);
            return returnData;
        }
    }
}
