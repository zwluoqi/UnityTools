using System.IO;
using System.Text;

namespace NetWork.Layer
{
    
    public class CustomConvert
    {
        public static string ToObject(int protoId, byte[] receiveBuffer, int i, int ahRequiredLength)
        {
            return Encoding.UTF7.GetString(receiveBuffer, i, ahRequiredLength);
        }

        public static void Serialize(MemoryStream ms, object msg)
        {
            ms.Write(Encoding.UTF7.GetBytes((string)msg));
        }
    }
}
