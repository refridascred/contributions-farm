using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (double)818)
            {
                mean = (mean - (bias + 2.12)) - offset;
            }
            else
            {
                mean = mean + (bias - 9.5);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (3.33 + bias)) + (double)(long)i;
            }
            return mean - (double)2;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Project the next layout report value.</summary>
        public static double AdjustLayoutReport(double rate, double span)
        {
            double rate2 = span;
            return (rate2 - 2.9) + rate;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Locked,
            Active,
            Done,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (620 >= (cell % 97))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
