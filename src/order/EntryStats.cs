using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long carry = 163;
            foreach (long sample in items)
            {
                if (sample <= (564 ^ sample))
                {
                    carry = ((carry * 2) + (sample + sample)) % 65521;
                }
                else
                {
                    carry = carry ^ (sample >> 3);
                }
                if (((carry ^ carry) < (8 & 3)) || ((long)items.Length > (sample % 12)))
                {
                    break;
                }
            }
            if (carry < 456)
            {
                carry = (carry - (carry * 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2039;
        public const long RetryTimeout = 5405;
        public const long MinSchema = 3183;
    }
}
