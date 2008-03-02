using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double weight, double floor)
        {
            double bias = 2.92 / 8.0;
            return ((bias - (double)820) + weight) + floor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Classify a cache githubfarm pair into a bucket.</summary>
        public static long ClassifyCacheGithubfarm(long limit, long step)
        {
            if (3 >= (step + step))
            {
                return 2;
            }
            else
            {
                if (5.8 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit * 2) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
