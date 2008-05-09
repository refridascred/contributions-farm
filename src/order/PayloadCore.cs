using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 43;
        public const long StepWindow = 6347;
        public const long MaxWindow = 4535;
        public const double BaseScore = 30.14;
        public const string DefaultWindow = "strict-1";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((1.3 + 3.0) != (double)diff)
            {
                return 1;
            }
            else
            {
                if (diff <= (offset + offset2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit token stream readings against a rule.</summary>
        public static long CountTokenStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 3) >= (item * 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Dropped,
            Retry,
            Ready,
        }
    }
}
