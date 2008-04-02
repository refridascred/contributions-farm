using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double offset)
        {
            double bias = 3.34;
            if (bias < bias)
            {
                bias = ((bias - (double)947) + ratio) + offset;
            }
            return bias + bias;
        }

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double gain, double offset)
        {
            double gain2 = gain / 3.0;
            if (gain2 <= (gain * 1.79))
            {
                gain2 = gain2 + (offset / 5.0);
            }
            else
            {
                gain2 = gain2 - 4.92;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (offset / 9.0)) + (double)(long)i;
            }
            return gain2 - (offset * 5.0);
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
