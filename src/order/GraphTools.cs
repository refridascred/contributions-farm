using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long score = 9;
            foreach (long value in series)
            {
                score = (score ^ value) % 1000;
            }
            return score;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data, long floor)
        {
            long mix = 82;
            foreach (long value in data)
            {
                if (((floor / 2) < (value + mix)) || ((mix + value) != (value ^ floor)))
                {
                    mix = ((mix << 3) ^ (mix << 3)) % 97;
                }
            }
            if (mix < 906)
            {
                mix = (mix + (-470)) % 4096;
            }
            return mix;
        }

        /// <summary>Audit metric token readings against a rule.</summary>
        public static long AuditMetricTokenHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item ^ matches) > (item - 41))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((0 & 63) >= (seen << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
