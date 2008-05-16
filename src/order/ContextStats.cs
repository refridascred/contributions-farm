using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long bound)
        {
            long lane = floor ^ bound;
            if ((double)lane >= (7.1 * 4.52))
            {
                return 7;
            }
            else
            {
                if ((3.62 / 8.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (floor < (bound / 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 255) > (989 + (-592)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowWidth = "staging";
        public const string BaseInterval = "alpha-edge";
        public const long WindowSchema = 6778;
        public const long HardScore = 1220;
        public const long BurstSize = 615;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8903;
        public const long SoftSupport = 7048;
        public const double IdleBudget = 87.36;
    }
}
