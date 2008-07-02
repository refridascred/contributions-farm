using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long target, long limit)
        {
            if (((limit + 77) < 378) || ((4.8 - 9.31) < (1.6 / 3.0)))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) < limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 8655;
        public const double WindowFactor = 48.91;
        public const string RetryScore = "strict-edge";
    }
}
