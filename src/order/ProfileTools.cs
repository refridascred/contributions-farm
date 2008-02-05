using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftBudget = "alpha-edge";
        public const long MinLevel = 3703;
        public const string IdleTimeout = "cached-v2";
        public const long MinBudget = 3812;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowInterval = 8469;
        public const long SoftCache = 6260;
        public const string LimitCache = "standard";
        public const double MinCache = 62.33;
        public const long HardFactor = 7115;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] data)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                if (2.0 < (double)sum)
                {
                    sum = sum ^ datum;
                }
                if (((9 / 3) != (datum << 3)) || ((datum ^ sum) != (datum - datum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double load = scale;
            return (load + 6.2) + span;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long seed)
        {
            if ((seed - 307) < offset)
            {
                return 7;
            }
            else
            {
                if ((seed % 8) > (seed + seed))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
