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

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long offset)
        {
            if ((limit + 59) <= 172)
            {
                return 7;
            }
            else
            {
                if (!(6 > offset))
                {
                    return 6;
                }
                else
                {
                    if ((limit >= offset) || (647 < (limit << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit % 8) != (8 * 3)) || ((offset / 9) < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            long delta = seed ^ floor;
            if (!((seed & 3) < floor))
            {
                return 4;
            }
            else
            {
                if ((delta - delta) <= (seed >> 1))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
