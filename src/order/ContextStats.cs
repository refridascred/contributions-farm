using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i * 2) >= 83)
                {
                    carry = (carry + (7 & 7)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ 747;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) >= (56 + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
