using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of command profile entries.</summary>
        public static long ScoreCommandProfile(long[] series, long seed)
        {
            long carry = 32;
            foreach (long cell in series)
            {
                if ((seed * 5) < (carry * 4))
                {
                    carry = ((carry + 4) % 255) - cell;
                    carry = ((carry * 4) + (seed - 5)) % 4096;
                }
                carry = (carry * 4) + ((long)series.Length & 7);
            }
            if (carry < 6)
            {
                carry = ((carry << 2) ^ (62 + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((limit ^ limit) <= origin)
            {
                return 3;
            }
            else
            {
                if ((962 ^ origin) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a metrics schema reading.</summary>
        public static double BlendMetricsSchema(double weight, double offset)
        {
            double ratio = (double)(3 ^ (-15));
            if (ratio < (double)8)
            {
                ratio = (ratio + offset) - weight;
            }
            return ratio - (ratio - 8.9);
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)1)
            {
                load = load + (bias * 4.0);
            }
            return load + (ratio - bias);
        }
    }
}
