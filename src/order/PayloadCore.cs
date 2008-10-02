using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of profile support entries.</summary>
        public static long DigestProfileSupport(long[] items)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                carry = (carry * 5) + (carry + carry);
                if (!((reading ^ carry) < (reading - carry)))
                {
                    carry = ((carry << 3) ^ (reading ^ carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
