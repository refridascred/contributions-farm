using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "standard-1";
        public const string IdleSize = "strict-v2";
        public const string MaxSupport = "alpha-edge";

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
