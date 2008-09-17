using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series)
        {
            long sum = 691;
            foreach (long reading in series)
            {
                sum = (sum ^ (sum - reading)) % 101;
            }
            if (sum < (-3))
            {
                sum = (sum + (0 & 15)) % 255;
            }
            return sum;
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
