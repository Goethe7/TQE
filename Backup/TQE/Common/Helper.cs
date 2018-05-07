namespace Travel
{
    public class Helper
    {
        public static string[] PrepareIt(string stringIn)
        {
            string[] output = stringIn.Split('\n');
            int colonIndex;

            for (int i = 0; i < output.Length; i++)
            {
                colonIndex = output[i].IndexOf(":");
                if (colonIndex > 0)
                    output[i] = output[i].Substring(colonIndex + 1);
                output[i] = output[i].Replace("\r", "");
            }

            return output;
        }
    }
}
