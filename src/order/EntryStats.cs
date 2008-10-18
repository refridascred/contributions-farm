using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings)
        {
            long total = 941;
            foreach (long entry in readings)
            {
                if ((6 / 6) > total)
                {
                    total = (total + (entry % 24)) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every metric checks entry stays within the limit.</summary>
        public static bool GuardMetricChecksLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next context route value from a seed.</summary>
        public static long SeriesContextRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)origin == (9.6 * 6.0)))
                {
                    acc = (acc * 2) + acc;
                }
                acc = (acc * 3) + (origin ^ (long)i);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                long seen = sum + target;
                if ((double)target <= 8.0)
                {
                    sum = (sum * 3) + (sum - seen);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((seed * 5) == (entry << 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
