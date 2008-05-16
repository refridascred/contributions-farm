using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Retry,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long carry = -41;
            foreach (long sample in series)
            {
                carry = ((carry - 84) % 4096) + sample;
                if ((carry & 31) != ((long)series.Length * 3))
                {
                    carry = carry + carry;
                }
            }
            if (carry > 28)
            {
                carry = carry + (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long CombineLayoutAccount(long[] series, long seed)
        {
            long state = 23;
            foreach (long entry in series)
            {
                if ((389 << 2) > seed)
                {
                    state = ((state << 3) ^ (seed >> 2)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 76.25;
        public const long IdleLevel = 1296;
        public const long CacheBudget = 4209;
        public const long LimitFactor = 9470;
        public const string RetryRatio = "fallback-edge";

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double gain = (rate * 11.0) + (offset * 8.4);
            if (gain >= offset)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (gain + rate);
            }
            return gain - (double)379;
        }
    }
}
