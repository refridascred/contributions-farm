using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((2.5 * 0.4) <= (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long origin)
        {
            long diff = limit ^ origin;
            if ((diff >> 2) >= (origin / 8))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) > (67 * 4))
                {
                    return 0;
                }
                else
                {
                    if (limit < (origin + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
