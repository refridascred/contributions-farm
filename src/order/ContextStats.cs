using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 675;
        public const double MaxSize = 1.31;
        public const long StepSpan = 4964;
        public const double DefaultTimeout = 30.85;
        public const long LimitCommits = 2276;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 7771;
        public const string WindowLevel = "latest-edge";
        public const long SoftFactor = 531;
        public const string IdleCommand = "latest-1";

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long offset)
        {
            if ((floor - offset) < (floor - floor))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (5.0 + 4.9))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 31) <= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)5 < (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
