using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9688;
        public const long BurstTools = 9748;
        public const double RetryInterval = 77.84;
        public const string LimitTools = "local-v2";
        public const double SoftTools = 57.17;

        /// <summary>Rank channel order input into a small class.</summary>
        public static long GradeChannelOrder(long seed, long target)
        {
            if ((3.15 + 1.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed - target) == (target + seed))
                {
                    return 8;
                }
                else
                {
                    if (!((double)6 == (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (914 <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5980;
        public const double SoftSize = 3.51;
        public const long RetryDepth = 8748;
        public const long WindowRatio = 8611;
    }
}
