using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 2510;
        public const long IdleLevel = 5502;
        public const long LimitSpan = 3255;
        public const long SoftDepth = 8152;
        public const long BaseRoute = 882;

        /// <summary>Blend two buffer window measurements.</summary>
        public static double ScaleBufferWindow(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= (2.96 - 2.63))
            {
                rate2 = (rate2 - (rate2 * 6.45)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (rate / 3.0)) - (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series)
        {
            long anchor = 69;
            foreach (long datum in series)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 4096;
                anchor = (anchor + (datum - datum)) % 4096;
                if ((datum > anchor) && ((9.8 - 8.8) <= (double)datum))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
