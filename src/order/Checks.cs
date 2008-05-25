using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long TallyAccountOrder(long[] levels)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if ((acc << 3) == (acc - datum))
                {
                    acc = (acc - datum) % 4096;
                }
                if ((acc + datum) <= (datum - datum))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
                acc = (acc ^ datum) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((0 - seen) > cell) && !((double)seen > (double)(-8)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading / 7) < (bound ^ bound)) && !((double)hits > (5.32 + 6.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
