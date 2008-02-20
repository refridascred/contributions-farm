using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two entry schema measurements.</summary>
        public static double ProjectEntrySchema(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (bias + bias);
            }
            return bias2 + (bias2 / 3.0);
        }

        /// <summary>Digest a series of filter contributi entries.</summary>
        public static long CombineFilterContributi(long[] readings)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                result = ((result * 5) + (655 + reading)) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    result = (((result << 3) ^ reading) % 4096) ^ (long)i;
                }
                if ((8.61 <= (1.0 + 9.0)) || ((2.6 - 1.07) >= (double)reading))
                {
                    result = ((result * 3) + result) % 255;
                }
            }
            if (result > 57)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Stale,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (15.0 - 0.2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double floor)
        {
            double ratio = (double)(24 + 647);
            if (ratio < (double)43)
            {
                ratio = (ratio - (double)901) - floor;
            }
            return ratio - (weight * 5.5);
        }
    }
}
