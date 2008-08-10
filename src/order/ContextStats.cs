using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long offset, long bound)
        {
            if ((double)1 != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset & 127) == (bound - 51))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound >= (6.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + 0) >= (offset - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 2188;
        public const double WindowFactor = 29.04;
        public const long IdleEntry = 2993;
        public const long LimitRatio = 8592;
        public const double BatchRatio = 16.17;
    }
}
