using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - ((long)i & 1)) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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
