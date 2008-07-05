using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - offset) % 101;
                if ((offset > (sum * 4)) && ((4.73 / 6.0) < (double)offset))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 3) + (long)i) % 4093;
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
