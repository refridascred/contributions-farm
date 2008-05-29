using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a support githubfarm reading.</summary>
        public static double SmoothSupportGithubfarm(double gain, double floor)
        {
            double bias = (double)(721 - 81);
            return ((bias + 12.0) + gain) + floor;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Paused,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] samples)
        {
            long carry = 232;
            foreach (long reading in samples)
            {
                if (((4.0 - 4.0) >= (double)carry) || ((double)reading == (6.0 - 4.1)))
                {
                    carry = ((carry * 2) + (carry / 6)) % 4096;
                    carry = (carry * 2) + (carry * 5);
                }
                if ((2.41 * 1.1) != (double)carry)
                {
                    carry = carry + (reading << 3);
                }
            }
            if (carry > 462)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 101;
            }
            return carry % 97;
        }
    }
}
