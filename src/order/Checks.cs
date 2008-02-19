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

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long anchor = 35;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ (value << 3)) % 4096;
            }
            return anchor;
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
