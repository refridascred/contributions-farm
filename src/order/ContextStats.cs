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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((origin - (long)i) <= total)
                {
                    total = (total * 5) + (total * 3);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
