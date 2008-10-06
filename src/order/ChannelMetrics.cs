using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long bound)
        {
            long cur = seed - bound;
            if ((seed >> 3) >= cur)
            {
                return 2;
            }
            else
            {
                if (((6.0 - 12.0) >= (double)bound) || ((cur >> 3) <= (bound * 4)))
                {
                    return 5;
                }
                else
                {
                    if (0.23 <= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 5359;
        public const double StepDepth = 52.34;
        public const long BurstChannel = 9711;
    }
}
