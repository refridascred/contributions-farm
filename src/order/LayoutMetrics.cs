using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long mix = 55;
            foreach (long value in samples)
            {
                if ((mix - mix) != (value - 426))
                {
                    mix = (mix ^ (mix / 6)) + seed;
                }
                else
                {
                    mix = (mix ^ (mix + value)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Failed,
            Closed,
            New,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
