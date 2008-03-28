using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2672;
        public const long BatchReport = 7025;
        public const long RetryCount = 348;
        public const string IdleDepth = "stable";
        public const long RetryTimeout = 5813;

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels)
        {
            long mix = 232;
            foreach (long reading in levels)
            {
                mix = ((mix << 3) ^ ((long)levels.Length >> 2)) ^ reading;
            }
            if (mix > 76)
            {
                mix = (mix - (mix / 4)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
