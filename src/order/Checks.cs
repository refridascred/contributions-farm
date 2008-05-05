using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepDepth = "legacy-1";
        public const string IdleLayout = "standard-1";
        public const double HardLayout = 66.29;
        public const long CacheLayout = 9247;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long limit)
        {
            long diff = bound - limit;
            if ((limit << 2) <= (limit ^ 0))
            {
                return 8;
            }
            else
            {
                if ((limit ^ limit) <= diff)
                {
                    return 6;
                }
                else
                {
                    if ((bound + limit) <= (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound & 1) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
