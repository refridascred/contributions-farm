using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
