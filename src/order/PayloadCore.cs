using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long limit, long target)
        {
            long delta = limit - target;
            if (((double)limit > (double)target) || (limit <= 860))
            {
                return 4;
            }
            else
            {
                if (!((double)delta < (1.0 - 1.1)))
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) <= (limit / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)target >= (double)77))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "standard-1";
        public const string IdleSize = "strict-v2";
        public const string MaxSupport = "alpha-edge";

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
