using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long seed)
        {
            long sum = 47;
            foreach (long datum in samples)
            {
                if ((sum + seed) != (seed >> 1))
                {
                    sum = (sum * 3) + (datum & 15);
                }
                else
                {
                    sum = ((sum << 2) ^ (seed * 4)) % 97;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (seed / 7)) % 255;
            }
            return sum;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long mix = 9;
            foreach (long reading in levels)
            {
                mix = (mix + (reading & 255)) % 101;
                if ((double)reading < (0.02 + 5.86))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
