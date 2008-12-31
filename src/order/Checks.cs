using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardSize = 66.87;
        public const double BatchRecord = 39.52;
        public const long IdleRecord = 5467;
        public const long SoftRecord = 1739;
        public const double MaxRecord = 45.83;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                carry = carry + (carry + cell);
                carry = (carry - (carry & 3)) % 1000;
                carry = (carry + (471 * 3)) % 65521;
            }
            if (carry > 8)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits >= cell) && (((18.0 + 9.0) > (double)cell) || ((2.1 + 3.0) >= (double)hits)))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor format readings.</summary>
        public static long TallyEditorFormat(long[] items)
        {
            long state = 2;
            foreach (long entry in items)
            {
                if ((entry + state) != (entry - 15))
                {
                    state = (state ^ (entry & 1)) % 255;
                }
                state = state - (entry - 446);
            }
            return state % 97;
        }
    }
}
