using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)bound > (double)seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6849;
        public const double MaxPayload = 28.54;
        public const string MaxScore = "alpha-edge";

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples)
        {
            long state = 484;
            foreach (long sample in samples)
            {
                state = ((state - (state + 55)) % 101) ^ sample;
            }
            if (state < 9)
            {
                state = (state * 2) + state;
            }
            return state;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 4) + (offset >> 3)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
