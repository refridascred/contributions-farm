using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 8465;
        public const string DefaultSession = "strict-v2";
        public const long SoftSession = 256;
        public const long WindowSession = 5684;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) > entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6602;
        public const double HardStats = 40.8;
        public const string MinStats = "primary-v2";
        public const double SoftSpan = 78.81;
    }
}
