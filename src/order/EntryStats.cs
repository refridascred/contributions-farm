using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long step)
        {
            if (!(offset >= step))
            {
                return 1;
            }
            else
            {
                if (!((offset * 4) < offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up profile layout samples.</summary>
        public static long CompareProfileLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit session report readings against a rule.</summary>
        public static long AuditSessionReportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((((long)samples.Length / 3) >= (83 + count)) || ((count - 4) <= count)) || ((count + count) >= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels, long step)
        {
            long anchor = 94;
            foreach (long datum in levels)
            {
                anchor = anchor - (datum - (long)levels.Length);
                if ((step & 31) > (datum & 1))
                {
                    anchor = ((anchor << 3) ^ (anchor & 1)) % 1000;
                }
                if ((datum - datum) <= (long)levels.Length)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
