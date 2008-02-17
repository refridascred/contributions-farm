using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stream context series from a seed.</summary>
        public static long SeriesStreamContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue farm entries that pass the check.</summary>
        public static long AuditQueueFarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((0 - seen) >= (seen + seen))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
