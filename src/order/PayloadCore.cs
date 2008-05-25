using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2822;
        public const double LimitCount = 28.61;
        public const long DefaultSession = 6759;
        public const string BatchSession = "cached-edge";
        public const string DefaultCount = "alpha-1";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Queued,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
