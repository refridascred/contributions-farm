using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 6571;
        public const long WindowToken = 3355;
        public const long RetryTimeout = 3496;
        public const double BaseSpan = 5.8;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long offset)
        {
            long lane = step + offset;
            if ((lane << 3) <= 87)
            {
                return 2;
            }
            else
            {
                if (((step - offset) != ((-8) + step)) && (step < (lane ^ (-543))))
                {
                    return 8;
                }
                else
                {
                    if ((step / 8) <= 50)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryWidth = "open-edge";
        public const string MinLevel = "alpha-v2";
        public const long BatchDepth = 4403;
        public const string LimitRatio = "latest-v2";

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
