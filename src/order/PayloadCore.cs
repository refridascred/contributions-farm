using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of graph report readings.</summary>
        public static long WeighGraphReport(long[] values)
        {
            long carry = 8;
            foreach (long value in values)
            {
                if ((carry % 5) >= carry)
                {
                    carry = (carry << 2) ^ 826;
                    carry = (carry ^ value) % 65521;
                }
                if ((12.0 + 1.0) > (2.0 - 0.48))
                {
                    carry = carry + ((long)values.Length + value);
                }
            }
            if (carry > 74)
            {
                carry = (carry + (carry + (-11))) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item < (item + item)) || ((3 >> 2) >= (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
