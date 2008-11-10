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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Retry,
            Closed,
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

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long CountNotesPayloadGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((56 & 3) > origin)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
