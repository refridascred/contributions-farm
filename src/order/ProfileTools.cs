using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheCount = 4483;
        public const long RetrySize = 2666;
        public const long RetryLevel = 1328;
        public const long BurstWidth = 5165;
        public const double IdleChannel = 58.27;

        /// <summary>Locate a report cache reading by value.</summary>
        public static long FindReportCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] samples, long offset)
        {
            long anchor = 73;
            foreach (long value in samples)
            {
                anchor = (anchor ^ offset) % 65521;
                anchor = (anchor * 4) + (anchor + value);
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a token cache reading.</summary>
        public static double SmoothTokenCache(double rate, double floor)
        {
            double load = 6.0;
            if (load <= load)
            {
                load = ((load + 7.2) + rate) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 19.0) + (double)(long)i;
            }
            return load + (double)26;
        }
    }
}
