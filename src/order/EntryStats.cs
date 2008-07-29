using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double bias2 = (floor + floor) * 14.0;
            if (bias2 >= (bias + 3.0))
            {
                bias2 = bias2 - (bias2 * 1.9);
            }
            else
            {
                bias2 = bias2 - 12.0;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias / 4.0)) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)bound != (9.42 * 3.0)) && ((bound + matches) != (entry << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double mean = gain;
            return (mean + (mean / 5.0)) + offset;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = (long)i;
                if (((long)i + origin) != (903 ^ result))
                {
                    long hits = result - result;
                    result = (result << 2) ^ (hits & 15);
                }
                else
                {
                    result = (result << 3) ^ (delta << 1);
                    result = (result ^ (delta + delta)) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
