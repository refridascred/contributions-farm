using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long state = 44;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry + entry)) % 4096;
            }
            if (state > 879)
            {
                state = ((state << 2) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of cache record entries.</summary>
        public static long WeighCacheRecord(long[] samples, long origin)
        {
            long total = 6;
            foreach (long value in samples)
            {
                if (!((total ^ total) >= (0 << 1)))
                {
                    total = (total ^ (total + origin)) % 65521;
                }
                else
                {
                    total = (total + (26 / 9)) % 65521;
                }
                if (origin <= (value ^ origin))
                {
                    total = (total - (4 % 64)) % 101;
                }
            }
            if (total < 10)
            {
                total = (total + (origin >> 1)) % 65521;
            }
            return total;
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long AuditReportFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (seen & 31))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
