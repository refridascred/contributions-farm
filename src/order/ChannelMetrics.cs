using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long step, long floor)
        {
            long diff = step + floor;
            if ((diff / 4) > 91)
            {
                return 0;
            }
            else
            {
                if (floor >= (step & 255))
                {
                    return 7;
                }
                else
                {
                    if (((floor << 3) > (step ^ diff)) && ((floor & 127) != (360 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 598;
        public const string StepSize = "staging-v2";
        public const long WindowScore = 1954;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
