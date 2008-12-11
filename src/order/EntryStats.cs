using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix ^ ((long)series.Length + 0)) - reading) - step;
                mix = (mix * 2) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long DigestFilterContext(long[] values)
        {
            long acc = 765;
            foreach (long value in values)
            {
                if (((930 ^ acc) < acc) || ((double)value < (double)acc))
                {
                    acc = ((acc << 2) ^ (69 >> 3)) % 1000;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc > 433)
            {
                acc = (acc * 4) + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many cache context samples are out of range.</summary>
        public static long AuditCacheContextGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((9.0 - 10.0) != (double)seen))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank profile batches input into a small class.</summary>
        public static long GradeProfileBatches(long offset, long floor)
        {
            if (((floor + offset) == (79 / 7)) && ((floor % 64) > offset))
            {
                return 0;
            }
            else
            {
                if (275 <= floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
