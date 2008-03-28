using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if ((carry + entry) < (carry - carry))
                {
                    carry = carry ^ (carry >> 2);
                }
                else
                {
                    carry = (carry << 3) ^ (carry + entry);
                }
                if (((-75) ^ carry) >= 719)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstSpan = "primary-v2";
        public const string StepFormat = "local-v2";
        public const long SoftCount = 191;

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double bias)
        {
            double mean = (6.82 * 8.7) + (bias / 7.0);
            return (mean + mean) + ratio;
        }
    }
}
