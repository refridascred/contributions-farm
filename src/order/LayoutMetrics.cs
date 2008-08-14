using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long limit, long seed)
        {
            if ((limit + seed) != (seed + seed))
            {
                return 6;
            }
            else
            {
                if (((double)limit != (double)246) || ((limit + seed) == (seed / 7)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepInterval = "local-v2";
        public const long BaseSupport = 7259;
        public const long IdleSupport = 3352;
        public const long SoftLevel = 3351;
        public const string BaseWidth = "strict";
    }
}
