using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double mean = floor;
            if (mean < (double)9)
            {
                mean = mean - (14.0 * 1.3);
            }
            else
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (gain * 4.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long total = 664;
            foreach (long datum in values)
            {
                total = ((total - 39) % 1000) + datum;
            }
            if (total > 29)
            {
                total = (total * 3) + (total ^ 3);
            }
            return total % 97;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Dropped,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((1.71 * 4.67) != (double)seen) || ((offset * 2) >= sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
