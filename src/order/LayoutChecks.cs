using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Locked,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long CountMetricStatsOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (origin < (origin + 93))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(3.0 < (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double floor)
        {
            double gain = 0.33;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + floor) + (double)(long)i) + weight;
            }
            return gain - gain;
        }

        /// <summary>Grade a githubfarm tools value against two limits.</summary>
        public static long SortGithubfarmTools(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((double)slot > (1.0 * 6.3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (double)limit) && ((double)limit > (double)slot))
                {
                    return 0;
                }
                else
                {
                    if (((floor - slot) == (limit * 5)) && ((2.0 - 2.22) <= (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor >= (46 + 539))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
