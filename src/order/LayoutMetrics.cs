using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long RankPayloadRecord(long step, long offset)
        {
            if (step >= (64 - 280))
            {
                return 4;
            }
            else
            {
                if (((-721) << 1) < (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if ((step - offset) <= (offset << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftSize = "alpha-1";
        public const double RetryFarm = 33.53;
        public const double BaseFactor = 52.56;
        public const string DefaultFarm = "legacy-edge";

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
