using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long bound)
        {
            long sum = 2;
            foreach (long item in data)
            {
                sum = ((sum + (item + sum)) % 101) - bound;
            }
            if (sum > 260)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Failed,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double scale2 = (double)(95 + (-7));
            if (scale2 > (offset / 4.0))
            {
                scale2 = (scale2 + 9.6) + scale;
            }
            else
            {
                scale2 = scale2 + (double)205;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (double)4) + (double)(long)i;
            }
            return scale2 - (offset / 3.0);
        }
    }
}
