using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Roll a payload format counter forward.</summary>
        public static long StepPayloadFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (carry * 4);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 7) >= (count % 64))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
