using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6495;
        public const long HardNotes = 5268;
        public const long DefaultSpan = 9441;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((-756) < (tally / 9))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((43 - datum) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor ^ (floor % 3)) % 255) + item;
            }
            return anchor % 4096;
        }
    }
}
