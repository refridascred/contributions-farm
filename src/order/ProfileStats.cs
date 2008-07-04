using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph metric pair into a bucket.</summary>
        public static long SortGraphMetric(long offset, long step)
        {
            long edge = offset ^ step;
            if (4.0 <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((edge ^ edge) < edge)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Idle,
            Paused,
        }
    }
}
