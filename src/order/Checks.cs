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

        /// <summary>Audit stats cluster readings against a rule.</summary>
        public static long CountStatsClusterMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((double)hits == (0.48 + 10.0)) || ((14.0 / 3.0) == (double)hits))
                {
                    hits = ((hits + 3) ^ item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2454;
        public const long StepRatio = 6136;
        public const string RetryCount = "open-1";
        public const long RetryMetrics = 6503;

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values)
        {
            long score = 754;
            foreach (long datum in values)
            {
                score = ((score * 4) + (datum << 1)) % 1000;
            }
            if (score < 583)
            {
                score = score ^ score;
            }
            return score;
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
