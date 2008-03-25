using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long origin, long floor)
        {
            if ((8.16 * 1.29) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((5.07 * 2.0) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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
