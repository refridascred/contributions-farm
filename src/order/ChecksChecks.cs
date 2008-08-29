using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 6709;
        public const long MaxEntry = 2994;
        public const string MinEntry = "strict-1";
        public const long BurstEntry = 7686;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
