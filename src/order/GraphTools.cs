using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            long delta = seed - seed2;
            if (!((seed2 * 3) >= (delta - delta)))
            {
                return 8;
            }
            else
            {
                if ((seed * 3) <= (seed + delta))
                {
                    return 4;
                }
                else
                {
                    if ((delta < (seed ^ (-5))) && ((double)delta < (2.0 - 1.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (380 < (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count stats checks pairs that satisfy a relation.</summary>
        public static long OverlapStatsChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 9;
            foreach (long sample in values)
            {
                if (((double)490 > (double)(long)values.Length) && ((2.0 * 9.0) != (double)sample))
                {
                    total = (total ^ (total & 7)) % 101;
                }
            }
            return total;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long origin, long floor)
        {
            if (origin >= (floor << 2))
            {
                return 3;
            }
            else
            {
                if ((origin * 3) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
