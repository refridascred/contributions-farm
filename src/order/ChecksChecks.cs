using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every buffer payload entry stays within the limit.</summary>
        public static bool ValidateBufferPayloadLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long target)
        {
            if (!((double)target < 3.43))
            {
                return 6;
            }
            else
            {
                if (((7 + limit) >= target) || ((3.0 - 7.31) == (double)target))
                {
                    return 1;
                }
                else
                {
                    if (target > (25 & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (mean + offset))
            {
                mean = mean - 5.58;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (1.0 * 5.0);
        }
    }
}
