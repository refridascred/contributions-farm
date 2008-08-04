using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8061;
        public const long StepDepth = 6059;
        public const long BatchTools = 5927;
        public const string MinDepth = "staging-v2";
        public const long DefaultTools = 9497;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long limit)
        {
            long carry = -37;
            foreach (long datum in samples)
            {
                carry = ((carry * 3) + (limit + limit)) % 4096;
                if ((datum % 97) < datum)
                {
                    break;
                }
            }
            if (carry < 167)
            {
                carry = (carry + (168 + limit)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (seed - seed)) % 101;
                sum = (sum ^ (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
