using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 1937;
        public const long SoftContributi = 2012;
        public const long BatchContributi = 4865;
        public const long HardInterval = 2396;
        public const string MinTimeout = "latest-1";

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool CheckStatsSupportLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long total = 7;
            foreach (long entry in series)
            {
                if (!((13.0 * 1.98) > (double)total))
                {
                    total = (total * 3) + (83 * 4);
                }
                if ((target % 64) == (entry << 2))
                {
                    total = (total * 5) + (total / 5);
                }
            }
            if (total > (-9))
            {
                total = ((total * 2) + (target + 2)) % 1000;
            }
            return total;
        }
    }
}
