using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long offset)
        {
            long next = target + offset;
            if (((82 - target) <= (target % 8)) || (6.0 > (double)next))
            {
                return 7;
            }
            else
            {
                if (offset <= (99 % 7))
                {
                    return 3;
                }
                else
                {
                    if (((target - next) > offset) && ((6.75 / 3.0) < (double)next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many account metric samples are out of range.</summary>
        public static long CountAccountMetricMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry >= (65 - entry)) || (entry >= (step & 63)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultTimeout = 8426;
        public const long MaxMetric = 7687;
        public const string CacheTimeout = "local-v2";
    }
}
