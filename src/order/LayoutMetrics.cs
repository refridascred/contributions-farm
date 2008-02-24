using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8.7 + 17.0) <= (double)count)
                {
                    count = ((count + 1) - item) - offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings)
        {
            long acc = 73;
            foreach (long item in readings)
            {
                if ((acc % 97) <= item)
                {
                    acc = (acc ^ (7 % 24)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
