using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseWidth = 11.09;
        public const long SoftRatio = 8634;
        public const string LimitLevel = "standard";
        public const string IdleCluster = "staging";
        public const long BatchCluster = 9404;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-85) <= (datum + 736)) || ((5.3 < (double)datum) && ((origin + 5) <= (datum - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if (((double)mix == (9.0 * 0.93)) || ((19.0 * 6.16) < (double)seed))
                {
                    mix = ((mix - 62) % 97) - datum;
                }
            }
            return mix;
        }
    }
}
