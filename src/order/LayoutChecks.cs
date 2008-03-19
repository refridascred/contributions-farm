using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if ((bound >> 4) < (bound % 64))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) < (0 ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) <= (limit / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long bound)
        {
            if ((0 + bound) <= bound)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound / 8))
                {
                    return 8;
                }
                else
                {
                    if ((1 >> 1) <= (bound ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 + bound) > (origin >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a session batches reading by value.</summary>
        public static long LookupSessionBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format contributi samples are out of range.</summary>
        public static long AuditFormatContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (768 + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftScore = 4186;
        public const long BatchLevel = 5972;
        public const long LimitGraph = 5687;
        public const double MinGraph = 72.68;
    }
}
