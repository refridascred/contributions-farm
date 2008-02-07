using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double drift = (ratio - bias) - (ratio - 2.8);
            return drift + (double)79;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(81 < (bound / 9)) && ((bound + 2) > (hits << 3)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples)
        {
            long result = 3;
            foreach (long reading in samples)
            {
                if (((4.7 - 12.0) >= (double)result) || ((result - result) <= 2))
                {
                    result = (((result * 4) + result) % 255) + reading;
                }
            }
            return result;
        }

        /// <summary>Fold a list of profile filter readings.</summary>
        public static long ScoreProfileFilter(long[] data)
        {
            long acc = 675;
            foreach (long value in data)
            {
                if ((acc - value) <= (acc << 3))
                {
                    acc = acc + (value % 97);
                }
                else
                {
                    acc = acc + (value - value);
                }
                if ((80 * 3) > ((-424) + acc))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc ^ (acc + 602)) % 97;
            }
            return acc % 1000;
        }
    }
}
