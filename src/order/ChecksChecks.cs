using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values, long step)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if ((7.7 - 5.0) == (double)(long)values.Length)
                {
                    acc = (((acc << 2) ^ (step % 2)) % 255) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading - seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double bias3 = bias2 - bias2;
            for (int i = 0; i < 3; i++)
            {
                bias3 = ((bias3 - (bias3 - bias2)) + (double)(long)i) + bias;
            }
            return bias3 - bias2;
        }
    }
}
