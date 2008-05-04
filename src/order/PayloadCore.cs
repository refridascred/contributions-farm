using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a window command pair into a bucket.</summary>
        public static long BucketWindowCommand(long bound, long target)
        {
            if ((target + bound) > bound)
            {
                return 3;
            }
            else
            {
                if (((double)target <= 0.2) || ((41 + bound) >= (bound ^ 390)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Ready,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long step)
        {
            long diff = floor ^ step;
            if ((floor + floor) < 4)
            {
                return 1;
            }
            else
            {
                if (step < (floor + 54))
                {
                    return 7;
                }
                else
                {
                    if (92 <= diff)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((9.45 + 7.9) == (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
