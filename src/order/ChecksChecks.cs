using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long total = 178;
            foreach (long entry in series)
            {
                if (total >= (total & 255))
                {
                    total = (total + entry) - seed;
                }
                else
                {
                    total = ((total * 4) + entry) % 65521;
                }
            }
            return total;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "primary-edge";
        public const long BaseScore = 1718;
        public const long MaxSize = 8103;
        public const long WindowTimeout = 4807;
    }
}
