using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 7591;
        public const long IdleLayout = 6106;
        public const long BurstWidth = 8702;
        public const string BatchRatio = "staging-1";
        public const long SoftLevel = 705;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long seed)
        {
            if ((double)offset < (1.16 - 8.0))
            {
                return 1;
            }
            else
            {
                if ((seed - seed) <= (offset & 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) <= (seed ^ 10))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
