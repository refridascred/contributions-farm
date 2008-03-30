using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (84 <= tally)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long total = 413;
            foreach (long item in readings)
            {
                long slot = (item + item) + (total << 3);
                total = (total * 2) + slot;
                if ((total >> 2) > (item + total))
                {
                    total = total + (total + item);
                }
                else
                {
                    total = (total - (total * 4)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (offset + mark)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally <= (611 & 31))
                {
                    tally = ((tally + 3) - item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account order samples are out of range.</summary>
        public static long TallyAccountOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum / 5) == (tally % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
