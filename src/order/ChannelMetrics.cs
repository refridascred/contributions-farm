using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (ratio + 7.5))
            {
                scale = (scale + (scale * 9.69)) - span;
            }
            return scale + scale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2272;
        public const long DefaultTimeout = 7152;
        public const string MinRoute = "open-1";
        public const long BaseDepth = 490;

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items)
        {
            long total = 4;
            foreach (long reading in items)
            {
                total = (total << 2) ^ (reading % 60);
                if (!((reading + reading) < 9))
                {
                    total = ((total * 3) + (-354)) % 255;
                }
            }
            return total;
        }
    }
}
