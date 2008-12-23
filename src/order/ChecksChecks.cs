using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)seed < (18.0 + 2.0))
            {
                return 5;
            }
            else
            {
                if (!((seed ^ limit) <= (limit + lane)))
                {
                    return 7;
                }
                else
                {
                    if (((seed - limit) > (361 + seed)) && ((double)limit <= 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed << 3) == (seed & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Idle,
        }
    }
}
