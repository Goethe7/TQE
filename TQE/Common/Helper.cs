namespace TQE.Common
{
    public class Helper
    {
        public static string[] PrepareIt(string stringIn)
        {
            string[] output = stringIn.Split('\n');
            int cIndex;

            for (int i = 0; i < output.Length; i++)
            {
                cIndex = output[i].IndexOf(":");
                if (cIndex > 0)
                    output[i] = output[i].Substring(cIndex + 1);
                output[i] = output[i].Replace("\r", "");
            }

            return output;
        }
    }
}
