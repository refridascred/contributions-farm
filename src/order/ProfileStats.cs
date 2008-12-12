using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((-68) - hits) < (hits / 7))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry counter readings.</summary>
        public static long CompareEntryCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Idle,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
