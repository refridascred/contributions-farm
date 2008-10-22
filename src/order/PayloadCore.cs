using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long AuditClusterFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)seen < 9.57) || ((4 + entry) <= (entry - (-26))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long TallyAlreadyFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((9 + 42) >= value) || ((value >= (value + 249)) && ((value - (long)values.Length) <= 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = 3;
            foreach (long item in series)
            {
                if (carry >= (carry + 42))
                {
                    carry = carry ^ (carry + 7);
                }
                carry = (carry * 5) + (carry >> 3);
                if (item > (3 - carry))
                {
                    carry = (carry + carry) % 101;
                }
                else
                {
                    carry = (carry ^ (carry ^ item)) % 255;
                }
            }
            if (carry < 249)
            {
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
