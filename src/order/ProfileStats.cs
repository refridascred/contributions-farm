using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long result = 17;
            foreach (long reading in items)
            {
                if (!((double)reading == (double)result))
                {
                    result = result - (target >> 5);
                }
                result = (result + 714) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Count tools metrics pairs that satisfy a relation.</summary>
        public static long CompareToolsMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data, long floor)
        {
            long anchor = 70;
            foreach (long item in data)
            {
                if ((3.9 / 4.0) < (double)(long)data.Length)
                {
                    anchor = ((((anchor * 3) + ((long)data.Length >> 5)) % 4096) - item) - floor;
                }
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4141;
        public const string MaxEntry = "legacy-1";
        public const long RetryWidth = 4858;
        public const long DefaultEntry = 5866;
    }
}
