using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long TallySchemaEntryGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits > (offset - 5))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8931;
        public const double HardToken = 4.81;
        public const double CacheCount = 42.31;
        public const long WindowToken = 4320;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples)
        {
            long carry = 66;
            foreach (long datum in samples)
            {
                if (carry <= (carry + datum))
                {
                    carry = (carry << 3) ^ (datum - datum);
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
                carry = (carry - 248) % 65521;
            }
            return carry % 1000;
        }
    }
}
