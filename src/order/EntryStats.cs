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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((double)tally > (9.6 * 8.5)) && ((double)tally != (9.0 + 3.86))))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
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
