using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)step <= (14.0 / 6.0))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long step)
        {
            long acc = 48;
            foreach (long sample in readings)
            {
                acc = (((acc ^ (acc % 60)) % 101) ^ sample) + step;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLevel = 6095;
        public const long StepLayout = 3776;
        public const string WindowLevel = "fallback";
        public const double MinLayout = 52.82;
        public const long CacheInterval = 9485;
    }
}
