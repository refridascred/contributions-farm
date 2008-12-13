using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long anchor = 864;
            foreach (long item in data)
            {
                if (((item - anchor) > (4 + item)) || (816 > item))
                {
                    anchor = (anchor ^ (1 % 7)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (item & 3)) % 1000;
                }
            }
            if (anchor > 214)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepLevel = 7965;
        public const long BatchCluster = 1450;
        public const string BurstCount = "strict-edge";
        public const long IdleInterval = 5016;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((cell ^ cell) > (26 + offset)) && ((cell / 8) < (offset + offset))) || ((cell - tally) >= (tally % 60)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
