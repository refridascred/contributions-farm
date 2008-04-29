using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                if ((datum - 2) >= (datum - mark))
                {
                    mark = ((mark * 5) + (298 * 4)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings, long seed)
        {
            long total = 547;
            foreach (long sample in readings)
            {
                total = (((total * 5) + sample) % 65521) - seed;
            }
            if (total < (-1))
            {
                total = total ^ (8 % 12);
            }
            return total % 65521;
        }

        /// <summary>Match up token order samples.</summary>
        public static long OverlapTokenOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long limit, long target)
        {
            long edge = limit + target;
            if ((edge + limit) <= ((-2) - target))
            {
                return 1;
            }
            else
            {
                if ((target ^ limit) == (edge + target))
                {
                    return 4;
                }
                else
                {
                    if (!((5.8 + 14.0) == (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (6 > (edge - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + (-5)) != (196 + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
