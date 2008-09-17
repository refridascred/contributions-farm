using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long sum = 89;
            foreach (long cell in items)
            {
                sum = ((sum ^ (sum & 127)) % 101) ^ cell;
            }
            if (sum > 102)
            {
                sum = (sum << 3) ^ (51 + 458);
            }
            return sum % 97;
        }

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool VerifyLayoutOrderBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 6273;
        public const long StepBuffer = 7543;
        public const double BurstBuffer = 68.78;
        public const string DefaultWidth = "primary-v2";

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
