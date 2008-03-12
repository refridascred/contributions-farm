using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((6.25 + 3.66) >= (double)anchor) || (((long)i & 3) <= anchor))
                {
                    anchor = (anchor - (anchor / 2)) % 101;
                }
                anchor = (anchor * 4) + ((long)i * 2);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 88.32;
        public const double MinSchema = 93.61;
        public const long DefaultSchema = 4177;
        public const string WindowLevel = "standard";
        public const double BurstScore = 56.13;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((55 - (long)readings.Length) < (tally % 2)) || (((double)tally > 9.6) || (reading > 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (mean - mean))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (bias2 - mean);
            }
            return mean - 7.6;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long state = 97;
            foreach (long datum in values)
            {
                if ((state % 60) > (state ^ 58))
                {
                    state = (state << 2) ^ datum;
                }
                else
                {
                    state = (state - (206 * 4)) % 65521;
                }
            }
            if (state < 89)
            {
                state = (state * 2) + state;
            }
            return state % 65521;
        }
    }
}
