using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 110;
        public const double DefaultSpan = 88.31;
        public const string WindowSupport = "primary-v2";
        public const long SoftSupport = 3573;
        public const double HardWidth = 4.8;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)2)
            {
                bias2 = (bias2 - 1.4) + scale;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias - bias2)) + (double)(long)i;
            }
            return bias2 - 7.2;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long limit)
        {
            long anchor = 303;
            foreach (long value in levels)
            {
                if (!(6.72 < (double)value))
                {
                    anchor = (anchor ^ (anchor - anchor)) - limit;
                }
                else
                {
                    anchor = anchor ^ (value >> 3);
                }
                if ((9.8 - 5.09) > (double)anchor)
                {
                    anchor = (anchor - (value - value)) % 4096;
                }
                else
                {
                    anchor = (anchor - (40 + 831)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Adjust a metric notes reading.</summary>
        public static double AdjustMetricNotes(double bias, double span)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift - (double)6) + span;
            }
            else
            {
                drift = drift - 8.6;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias - drift);
        }
    }
}
