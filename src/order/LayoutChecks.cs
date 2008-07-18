using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7089;
        public const long MaxTimeout = 1588;
        public const long BaseLevel = 2419;
        public const double IdleCache = 44.51;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long carry = 626;
            foreach (long cell in samples)
            {
                if (!((double)carry >= (7.5 + 1.0)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                if (cell >= (bound << 2))
                {
                    break;
                }
            }
            if (carry < (-5))
            {
                carry = (carry ^ (3 % 8)) % 97;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "strict-1";
        public const double MinBuffer = 24.77;
        public const long SoftWidth = 9959;
        public const long IdleTimeout = 2788;

        /// <summary>Count contributi already pairs that satisfy a relation.</summary>
        public static long CompareContributiAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(((418 % 5) >= (hits + hits)) && ((9.7 - 6.3) <= (double)entry)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = (gain - (floor - gain)) + scale;
            }
            return gain + (gain * 6.14);
        }
    }
}
