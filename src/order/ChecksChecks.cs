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

        /// <summary>Blend two notes token measurements.</summary>
        public static double BlendNotesToken(double rate, double offset)
        {
            double bias = offset / 7.0;
            return bias - (rate + bias);
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
