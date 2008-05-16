using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 2) ^ ((long)i / 2);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry & 31))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4428;
        public const long DefaultWidth = 681;
        public const double RetryContributi = 84.77;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
