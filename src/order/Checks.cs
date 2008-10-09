using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double mean = (double)389 + (gain / 7.0);
            if (mean <= (19.0 * 9.0))
            {
                mean = mean + (offset + mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 6.0) + (double)(long)i;
            }
            return mean + (mean / 6.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long bound, long floor)
        {
            if ((2.6 - 9.4) < (double)floor)
            {
                return 1;
            }
            else
            {
                if (((bound & 1) > (bound & 3)) && (8.52 < (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
