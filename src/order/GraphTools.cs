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

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Limit { get; set; }
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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (origin < (origin % 64))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
