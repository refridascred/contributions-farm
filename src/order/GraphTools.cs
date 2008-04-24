using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > (entry * 4))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long step)
        {
            if ((0.64 + 9.53) != (double)step)
            {
                return 3;
            }
            else
            {
                if ((step * 3) == (origin / 6))
                {
                    return 6;
                }
                else
                {
                    if ((step * 3) >= (origin - step))
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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((item ^ tally) >= item) || (item < (tally >> 2))))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
