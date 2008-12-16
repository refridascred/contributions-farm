using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate queue checks samples.</summary>
        public static long FoldQueueChecks(long[] readings)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                carry = (carry + carry) ^ datum;
            }
            if (carry < 390)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSize = 16.67;
        public const long BaseSize = 9734;
        public const double BatchDepth = 20.41;
        public const long BurstSpan = 1526;
        public const long MinInterval = 5630;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
