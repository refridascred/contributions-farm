using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepInterval = 36.36;
        public const long BatchDepth = 3870;
        public const double DefaultProfile = 7.61;
        public const double WindowLevel = 79.24;

        /// <summary>Digest a series of farm already entries.</summary>
        public static long ScoreFarmAlready(long[] items, long seed)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = (((acc - acc) % 97) + cell) + seed;
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items)
        {
            long mark = 819;
            foreach (long item in items)
            {
                mark = (mark ^ (item + item)) % 1000;
            }
            if (mark < 6)
            {
                mark = ((mark << 3) ^ (24 % 2)) % 65521;
            }
            return mark;
        }
    }
}
