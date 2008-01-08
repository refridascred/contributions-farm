using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double RetryCluster = 47.29;
        public const double StepCluster = 61.69;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((930 * 2) < (sample + 5)) && ((double)seen <= (6.6 / 2.0)))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
