using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate record stats samples.</summary>
        public static long ScoreRecordStats(long[] levels, long limit)
        {
            long mark = 498;
            foreach (long cell in levels)
            {
                mark = ((mark + (cell >> 2)) % 65521) - limit;
            }
            return mark % 1000;
        }

        /// <summary>Match up session counter samples.</summary>
        public static long CompareSessionCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Retry,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((origin >> 5) < (9 / 4))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
