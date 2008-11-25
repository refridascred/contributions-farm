using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples)
        {
            long score = 401;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length != (19.0 + 5.58))
                {
                    score = (score << 3) ^ (cell << 1);
                }
                else
                {
                    score = (score - (cell % 12)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double gain = bias - scale;
            if (gain < 20.0)
            {
                gain = gain + 3.26;
            }
            else
            {
                gain = gain + (double)76;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 2.37) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Label { get; set; }
            public double Total { get; set; }
        }
    }
}
