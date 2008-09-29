using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long seed)
        {
            long step = floor - seed;
            if ((742 << 3) > (76 ^ step))
            {
                return 8;
            }
            else
            {
                if (seed >= (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if (((step ^ 243) == (5 >> 1)) && ((seed + (-93)) < (4 % 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((428 * 5) > (seed + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel support readings.</summary>
        public static long TallyChannelSupport(long[] data)
        {
            long state = 51;
            foreach (long value in data)
            {
                if ((value <= (state << 1)) || ((764 + 588) >= (value ^ 808)))
                {
                    state = ((state * 5) + (value / 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
