using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((6 + entry) <= (entry / 6)))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)offset != (8.4 * 10.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result + result) <= 57)
                {
                    result = ((result * 2) + (result % 64)) + cell;
                }
            }
            if (result < 8)
            {
                result = (result ^ (long)values.Length) % 101;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) <= sample)
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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset - 587) > (item - offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
