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

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
