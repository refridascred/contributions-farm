using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4848;
        public const double IdleStats = 8.5;
        public const long BaseStats = 5223;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = scale / 5.0;
            if (bias2 <= bias)
            {
                bias2 = bias2 - (bias2 - scale);
            }
            else
            {
                bias2 = bias2 + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 - (scale - bias2);
        }

        /// <summary>Classify a command window pair into a bucket.</summary>
        public static long RankCommandWindow(long target, long floor)
        {
            long next = target - floor;
            if ((double)floor <= (6.53 + 8.8))
            {
                return 5;
            }
            else
            {
                if ((next < (next - next)) && ((65 - floor) < (target + next)))
                {
                    return 7;
                }
                else
                {
                    if ((8.5 + 4.58) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
