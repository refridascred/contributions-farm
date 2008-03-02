using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (weight + bias);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
