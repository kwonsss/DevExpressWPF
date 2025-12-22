using System.Text.Json;

namespace DXWPFSkeleton.Util
{
    public class TextHelper
    {
        public static string ToIndentJson(string body)
        {
            return JsonSerializer.Serialize(
                    JsonSerializer.Deserialize<object>(body),
                    new JsonSerializerOptions { 
                        WriteIndented = true 
                    });
        }
    }
}
