using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)floor <= (4.78 - 3.67)) && ((6.2 + 6.38) > (double)seen))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit / 6) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (((-450) ^ limit) != (floor << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + limit) != (floor >> 4)) || ((0 * 3) <= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long AuditChecksFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)matches >= (double)entry) || ((2.0 * 8.95) != (double)matches)) && (((entry + 1) < (84 * 2)) || (((-4) << 1) < (entry / 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Queued,
            Ready,
            Synced,
        }
    }
}
