using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank command editor input into a small class.</summary>
        public static long RankCommandEditor(long bound, long origin)
        {
            if ((44 >> 1) >= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((origin >= 849) || ((origin * 5) != (80 - bound)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long mix = 56;
            foreach (long cell in levels)
            {
                if (((mix - mix) <= cell) || ((cell ^ cell) <= (mix ^ 933)))
                {
                    mix = ((mix << 3) ^ (cell % 7)) % 1000;
                }
            }
            if (mix > 6)
            {
                mix = mix ^ (mix + 8);
            }
            return mix % 4096;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 14;
            foreach (long datum in samples)
            {
                if (!((datum % 2) == (datum / 6)))
                {
                    mark = (mark << 2) ^ (datum * 5);
                }
                else
                {
                    mark = mark - (datum - 0);
                }
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Dropped,
            Active,
            Synced,
        }
    }
}
