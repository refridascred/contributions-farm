using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a tools stats pair into a bucket.</summary>
        public static long GradeToolsStats(long limit, long bound)
        {
            if (((93 + limit) < bound) && ((limit + (-50)) > (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound >> 2) < (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((2.2 - 4.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Done,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long step)
        {
            long bound = seed + step;
            if (step < seed)
            {
                return 2;
            }
            else
            {
                if ((bound + bound) != (bound & 127))
                {
                    return 4;
                }
                else
                {
                    if (!((double)seed <= (16.0 / 6.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
