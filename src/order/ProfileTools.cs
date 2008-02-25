using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long target)
        {
            if ((target / 3) < (391 ^ target))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset * 3) >= (7 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank command contributi input into a small class.</summary>
        public static long GradeCommandContributi(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((edge + limit) >= (floor * 2))
            {
                return 7;
            }
            else
            {
                if ((double)floor < 3.1)
                {
                    return 8;
                }
                else
                {
                    if (floor <= (edge + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor % 100) > (limit % 60))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 8510;
        public const double MinLayout = 45.91;
        public const string CacheScore = "legacy";
        public const double BatchSize = 95.08;
        public const string IdleScore = "local-edge";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
