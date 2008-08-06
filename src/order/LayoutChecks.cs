using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Synced,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long floor)
        {
            if ((floor - floor) > 12)
            {
                return 0;
            }
            else
            {
                if (80 > step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample > (long)items.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] series, long origin)
        {
            long sum = -593;
            foreach (long value in series)
            {
                if (1 < (sum + sum))
                {
                    sum = (sum ^ (0 * 3)) % 1000;
                }
                if ((double)origin != (8.6 / 9.0))
                {
                    sum = (sum + (value - origin)) % 97;
                }
                else
                {
                    sum = (sum - (sum - origin)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7138;
        public const long HardCache = 8634;
        public const long CacheSize = 5049;
        public const long WindowCache = 2235;
    }
}
