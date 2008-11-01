using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSpan = 42.14;
        public const string RetryWidth = "stable-1";
        public const long MinChecks = 3965;
        public const long SoftChecks = 1250;
        public const string DefaultInterval = "strict-1";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Dropped,
            New,
            Active,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples, long target)
        {
            long sum = 943;
            foreach (long value in samples)
            {
                if (!(target <= (target & 63)))
                {
                    sum = (sum - (3 - sum)) % 97;
                }
                if ((double)value > 8.37)
                {
                    sum = ((sum * 5) + sum) % 65521;
                }
                else
                {
                    sum = sum - target;
                }
                if ((737 - 4) >= value)
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
