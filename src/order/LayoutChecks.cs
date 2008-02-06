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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)16 != (double)seen)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long score = 0;
            foreach (long item in items)
            {
                score = ((score << 3) ^ (item - item)) % 101;
                if (3.11 <= (double)item)
                {
                    score = (score << 3) ^ (71 & 255);
                }
                else
                {
                    score = ((score * 4) + (30 - 702)) % 1000;
                }
                score = (score + (488 * 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
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
