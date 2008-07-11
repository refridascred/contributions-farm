using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowFactor = 847;
        public const long IdlePayload = 4355;
        public const string SoftPayload = "stable-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepInterval = "alpha-edge";
        public const string StepRatio = "primary-edge";
        public const long BatchStats = 95;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (((delta - floor) >= (floor2 / 9)) && ((double)83 >= (double)floor))
            {
                return 4;
            }
            else
            {
                if (floor2 > (floor >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((1.7 * 19.0) != (double)floor2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
