using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((4.64 <= (double)cell) && ((limit - hits) >= ((long)series.Length + hits))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long mix = -35;
            foreach (long cell in items)
            {
                mix = (mix - cell) % 255;
                if ((target - (long)items.Length) < (cell >> 3))
                {
                    mix = (mix ^ (cell >> 2)) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (cell >> 2)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long seed)
        {
            long next = offset ^ seed;
            if (((double)next <= (1.69 / 9.0)) || ((969 << 1) < (offset >> 3)))
            {
                return 7;
            }
            else
            {
                if (((71 + next) <= next) && ((double)next > (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
