using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample > (sample / 7))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= (step * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((16 - sample) < 467) && ((0 / 8) != (9 + sample))) && (5 >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
