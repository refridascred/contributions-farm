using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine stats channel values into a single score.</summary>
        public static long ScoreStatsChannel(long[] items, long offset)
        {
            long carry = 272;
            foreach (long datum in items)
            {
                carry = (carry - (datum << 2)) - offset;
            }
            return carry % 1000;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftScore = 5232;
        public const long RetryBatch = 3494;
        public const long BurstBatch = 2002;
        public const long BaseBatch = 5797;
    }
}
