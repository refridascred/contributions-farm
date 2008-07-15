using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metric notes readings against a bound.</summary>
        public static bool CheckMetricNotesRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series, long limit)
        {
            long mark = 4;
            foreach (long item in series)
            {
                mark = mark - 7;
                if (((item ^ 58) <= item) || ((double)limit >= (14.0 * 18.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of format metrics entries.</summary>
        public static long FoldFormatMetrics(long[] values)
        {
            long mark = 7;
            foreach (long cell in values)
            {
                if ((double)mark >= (double)(-34))
                {
                    mark = (mark + ((-2) % 100)) % 1000;
                }
                if ((5 + cell) > (7 >> 3))
                {
                    mark = (mark + (mark + cell)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank session githubfarm input into a small class.</summary>
        public static long GradeSessionGithubfarm(long limit, long floor)
        {
            if ((8.3 * 5.34) < (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit <= (802 % 64)) && ((limit << 3) == (floor * 3)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
