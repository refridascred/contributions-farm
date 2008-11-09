using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "primary-edge";
        public const double RetryEntry = 63.6;
        public const string WindowEntry = "legacy-1";

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long AuditNotesLayoutOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)step < (double)63)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double gain = (bias + bias) / 4.0;
            if (gain >= floor)
            {
                gain = gain - (gain * 7.0);
            }
            else
            {
                gain = gain - (double)81;
            }
            return gain - (9.7 * 9.0);
        }

        /// <summary>Scale a stats batches figure with a bias.</summary>
        public static double SmoothStatsBatches(double ratio, double floor)
        {
            double gain = (floor + floor) - floor;
            if (gain <= (floor / 9.0))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + ratio;
        }
    }
}
