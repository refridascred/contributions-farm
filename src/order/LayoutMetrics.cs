using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long floor)
        {
            long lane = bound + floor;
            if (!((floor & 31) != (bound - bound)))
            {
                return 8;
            }
            else
            {
                if ((7.0 - 5.0) == (double)lane)
                {
                    return 6;
                }
                else
                {
                    if (9.4 > (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next support profile value from a seed.</summary>
        public static long DeriveSupportProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 2839;
        public const long HardPayload = 3843;
        public const long HardWidth = 421;
        public const long BaseSpan = 1406;
        public const double DefaultTimeout = 47.71;
    }
}
