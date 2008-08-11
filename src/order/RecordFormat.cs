using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + datum) == (hits + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Iterate the graph already series from a seed.</summary>
        public static long IterateGraphAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                long prev = ((long)i - state) % 3;
                long matches = (target & 15) & 31;
                if ((target ^ matches) > (matches / 7))
                {
                    state = (state << 2) ^ (prev / 4);
                }
                else
                {
                    prev = prev + matches;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
