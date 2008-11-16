using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9242;
        public const double StepLevel = 5.13;
        public const double IdleRatio = 59.24;
        public const long MinAlready = 3557;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if ((6.8 * 11.0) <= (double)datum)
                {
                    mix = ((mix * 3) + ((-75) + mix)) % 101;
                }
                else
                {
                    mix = mix + (mix + datum);
                }
            }
            if (mix > 31)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long floor)
        {
            if ((origin & 255) < (origin ^ floor))
            {
                return 5;
            }
            else
            {
                if ((double)6 != (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
