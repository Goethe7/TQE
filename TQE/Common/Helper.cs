using System;

namespace TQE.Common
{
    public static class Helper
    {
        public static string[] PrepareIt(string stringIn)
        {
            var output = stringIn.Split('\n');

            for (var i = 0; i < output.Length; i++)
            {
                var cIndex = output[i].IndexOf(":", StringComparison.Ordinal);
                if (cIndex > 0)
                {
                    output[i] = output[i].Substring(cIndex + 1);
                }

                output[i] = output[i].Replace("\r", "");
            }

            return output;
        }
    }
}
