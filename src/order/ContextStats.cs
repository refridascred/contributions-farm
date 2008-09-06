using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits + (long)data.Length) >= (127 & 127))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long carry = 668;
            foreach (long datum in readings)
            {
                if ((double)carry >= (16.0 + 5.3))
                {
                    carry = carry ^ (carry * 4);
                }
                if (((double)carry > (3.4 / 3.0)) && (7 >= (datum % 3)))
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleCount = "latest";
        public const double StepRatio = 46.24;
        public const double StepSize = 15.97;
        public const long BatchCount = 1805;
        public const string BatchLevel = "primary-1";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Failed,
            Dropped,
            Retry,
        }
    }
}
