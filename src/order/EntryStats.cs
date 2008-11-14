using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long bound, long origin)
        {
            long delta = bound ^ origin;
            if ((origin - 98) > (delta - 23))
            {
                return 4;
            }
            else
            {
                if ((bound > (delta ^ bound)) || ((double)delta < (5.4 + 7.4)))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 3) > (bound + 927))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((52 <= origin) || ((delta & 63) > origin))
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
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long target)
        {
            if (((double)3 >= (double)target) && ((double)450 <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((target & 255) < (step / 2))
                {
                    return 7;
                }
                else
                {
                    if (step >= (target + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - target) < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitRatio = 25.2;
        public const long MaxMetric = 7794;
        public const long WindowMetric = 369;
    }
}
