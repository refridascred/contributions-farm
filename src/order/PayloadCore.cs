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

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long anchor = 86;
            foreach (long sample in values)
            {
                if ((sample ^ sample) >= (anchor % 8))
                {
                    anchor = ((anchor << 3) ^ (sample >> 3)) % 1000;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor + (anchor + (long)values.Length);
            }
            return anchor % 65521;
        }
    }
}
