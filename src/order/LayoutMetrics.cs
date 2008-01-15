using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long origin2)
        {
            long diff = origin - origin2;
            if (!((diff ^ diff) < (diff - origin2)))
            {
                return 1;
            }
            else
            {
                if ((0.9 / 7.0) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc << 1)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
