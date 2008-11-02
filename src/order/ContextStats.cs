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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double bias2 = (double)(-8) + bias;
            if (bias2 > (double)1)
            {
                bias2 = bias2 - 1.4;
            }
            else
            {
                bias2 = bias2 + offset;
            }
            return bias2 + (offset + 2.9);
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
