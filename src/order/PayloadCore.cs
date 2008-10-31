using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of session editor readings.</summary>
        public static long FoldSessionEditor(long[] samples)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                carry = ((carry + 26) % 101) - entry;
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry % 97;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long AuditEntryLayoutMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)seen)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
