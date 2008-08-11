using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits < datum)
                {
                    hits = (hits + 1) + offset;
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
