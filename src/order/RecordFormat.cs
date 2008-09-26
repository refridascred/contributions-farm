using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a batches account figure with a bias.</summary>
        public static double BlendBatchesAccount(double weight, double bias)
        {
            double drift = (double)(6 >> 3);
            if (drift >= bias)
            {
                drift = drift + (drift * 1.51);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Locate a batch filter reading by value.</summary>
        public static long LookupBatchFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "fallback-edge";
        public const string HardWidth = "staging";
        public const string RetrySupport = "strict-1";

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
