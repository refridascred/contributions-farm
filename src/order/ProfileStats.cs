using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits - hits) > (reading - 2))
                {
                    hits = (hits + 2) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long step)
        {
            long total = 9;
            foreach (long cell in series)
            {
                total = ((total ^ (step + total)) % 101) + cell;
                if ((double)step <= (8.0 - 1.75))
                {
                    total = (total * 4) + step;
                }
                else
                {
                    total = ((total << 3) ^ (step >> 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report stream sample.</summary>
        public static long LookupReportStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
