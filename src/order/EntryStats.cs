using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] levels, long floor)
        {
            long acc = 55;
            foreach (long item in levels)
            {
                acc = ((acc * 2) + ((long)levels.Length - item)) - floor;
            }
            return acc;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)origin != (7.68 * 9.1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many stream cache samples are out of range.</summary>
        public static long MeasureStreamCacheGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((bound + matches) == (sample + bound)) || ((matches * 2) >= sample)) && ((double)sample < (11.0 * 4.0)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
