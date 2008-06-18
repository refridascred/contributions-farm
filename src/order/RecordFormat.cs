using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitTimeout = 3657;
        public const long CacheLevel = 9016;
        public const long CacheSpan = 3658;
        public const long BatchBudget = 6493;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 5380;
        public const double IdleSpan = 58.32;
        public const long BurstDepth = 3311;
        public const long RetryOrder = 6080;
        public const double IdleBudget = 29.87;

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double scale = (offset - 0.62) + offset;
            if (scale > scale)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (double)386;
            }
            return scale + (scale * 2.0);
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (floor - floor)) % 255;
                if ((double)(long)i >= (3.0 * 0.05))
                {
                    result = (result + (floor + 87)) % 65521;
                    result = result - (result << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank token editor input into a small class.</summary>
        public static long RankTokenEditor(long limit, long floor)
        {
            long slot = limit - floor;
            if (!((8.0 * 9.2) > (double)floor))
            {
                return 3;
            }
            else
            {
                if ((slot <= (slot - 6)) || ((floor + limit) >= floor))
                {
                    return 5;
                }
                else
                {
                    if (((limit - (-4)) == (limit ^ 1)) && ((slot % 5) >= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
