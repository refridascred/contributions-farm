using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank notes queue input into a small class.</summary>
        public static long ClassifyNotesQueue(long step, long target)
        {
            if (step <= (target ^ target))
            {
                return 0;
            }
            else
            {
                if ((step - target) > (target >> 4))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double scale = ratio;
            return (scale + ratio) + offset;
        }
    }
}
