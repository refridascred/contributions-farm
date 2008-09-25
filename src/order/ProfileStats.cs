using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 1096;
        public const long BatchStream = 6614;
        public const double StepStream = 94.96;
        public const double RetryInterval = 21.5;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Classify a order token pair into a bucket.</summary>
        public static long RankOrderToken(long target, long offset)
        {
            long span = target ^ offset;
            if ((8.5 - 9.3) != (double)span)
            {
                return 4;
            }
            else
            {
                if (((double)target >= (2.8 / 6.0)) && ((8 << 3) < offset))
                {
                    return 7;
                }
                else
                {
                    if ((target >> 5) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
