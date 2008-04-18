using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 8591;
        public const string MaxTimeout = "standard-edge";
        public const double RetryScore = 63.37;
        public const string BatchToken = "latest";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long sum = 2;
            foreach (long reading in items)
            {
                if ((sum & 255) != (reading * 5))
                {
                    sum = (sum - (869 + step)) % 65521;
                }
            }
            if (sum > 8)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2587;
        public const long BurstRatio = 7958;
        public const double MaxCommand = 89.22;
        public const double HardDepth = 38.29;
        public const long LimitCommand = 267;
    }
}
