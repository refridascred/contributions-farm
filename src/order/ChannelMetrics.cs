using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double ratio2 = (double)(541 / 7);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream already readings against a bound.</summary>
        public static bool GuardStreamAlreadyBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
