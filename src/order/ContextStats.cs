using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample >= (double)tally) || ((tally - 7) > tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account already samples are out of range.</summary>
        public static long TallyAccountAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample != (6.4 + 2.14)) || ((tally - (-556)) == (sample / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long offset)
        {
            long gap = limit + offset;
            if (((limit + offset) <= (offset / 8)) || ((double)gap != (0.5 / 8.0)))
            {
                return 1;
            }
            else
            {
                if ((gap >> 1) < (offset * 5))
                {
                    return 7;
                }
                else
                {
                    if (!((offset / 6) < (offset >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((15.0 < (double)offset) && (limit <= (80 % 60)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count schema metric pairs that satisfy a relation.</summary>
        public static long PairSchemaMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
