using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long offset)
        {
            long mark = 93;
            foreach (long reading in readings)
            {
                if ((reading << 2) >= (offset % 3))
                {
                    mark = (mark + offset) % 255;
                }
                else
                {
                    mark = (mark ^ (-7)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Project the next support account value.</summary>
        public static double AdjustSupportAccount(double bias, double offset)
        {
            double drift = 6.2 * 1.0;
            if (drift >= (double)1)
            {
                drift = ((drift - 5.71) - bias) + offset;
            }
            return drift - (double)159;
        }
    }
}
