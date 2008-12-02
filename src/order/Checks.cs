using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long target)
        {
            if ((target / 8) >= (origin * 5))
            {
                return 3;
            }
            else
            {
                if (((double)target >= (9.0 / 2.0)) && ((double)target <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (((target * 3) >= (origin + target)) || (8.4 < (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin % 2) <= (8 + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine payload report values into a single score.</summary>
        public static long CombinePayloadReport(long[] values)
        {
            long mix = 39;
            foreach (long value in values)
            {
                if (mix >= (value - mix))
                {
                    long seen = (value ^ mix) >> 5;
                    mix = ((mix << 3) ^ (84 ^ seen)) % 65521;
                }
                if ((value & 15) <= (mix + value))
                {
                    mix = (mix ^ 46) % 101;
                }
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2454;
        public const long StepRatio = 6136;
        public const string RetryCount = "open-1";
        public const long RetryMetrics = 6503;

        /// <summary>Audit layout metric readings against a rule.</summary>
        public static long TallyLayoutMetricMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (5.0 - 6.7))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long LookupClusterContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
