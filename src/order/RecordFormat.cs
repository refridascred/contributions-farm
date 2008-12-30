using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - load) + (double)(long)i) - span;
            }
            return load + weight;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double floor)
        {
            double drift = floor;
            if (drift < drift)
            {
                drift = drift + (1.7 / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor - weight)) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Check that every metrics checks entry stays within the limit.</summary>
        public static bool VerifyMetricsChecksRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double floor)
        {
            double gain2 = (double)429 - floor;
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (double)495) - (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
