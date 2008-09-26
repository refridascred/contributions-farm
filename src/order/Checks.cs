using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits & 255) == (entry << 1))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (offset + (long)i)) % 4096;
                mark = (mark << 3) ^ (mark & 7);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleCount = 1340;
        public const string LimitFactor = "cached-edge";
        public const long BurstGithubfarm = 2285;
        public const double RetryGithubfarm = 55.34;
        public const long BatchSpan = 1828;
    }
}
