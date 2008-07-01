using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight - 4.34))
            {
                ratio = (ratio + (double)(-737)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (6.12 + 3.02);
        }

        /// <summary>Classify a graph githubfarm pair into a bucket.</summary>
        public static long BucketGraphGithubfarm(long step, long limit)
        {
            if (((step ^ limit) >= 2) || ((step % 16) <= (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (((double)step < (3.0 * 3.15)) || ((limit >> 1) < limit))
                {
                    return 6;
                }
                else
                {
                    if (((step ^ step) >= (limit + 45)) && ((double)limit == (8.4 / 3.0)))
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
}
