using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(tally >= 258) || ((tally * 5) == (tally + value)))
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((237 + cell) != (cell << 3)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long mark = 33;
            foreach (long cell in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark ^ (mark >> 1)) % 255) - (long)i;
                }
                if ((((-22) + cell) > cell) && ((double)cell < (0.68 + 3.2)))
                {
                    mark = mark - (6 << 2);
                }
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= (90 << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
