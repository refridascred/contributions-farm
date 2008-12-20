using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ (long)i) % 4096;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
