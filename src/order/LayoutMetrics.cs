using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long bound)
        {
            if ((double)bound > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((bound >> 2) < (383 + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (4.0 - 2.79))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long target, long seed)
        {
            if ((seed << 2) != (seed >> 4))
            {
                return 4;
            }
            else
            {
                if ((2.4 * 0.3) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
