using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 28;
        public const long IdleTimeout = 2207;
        public const long DefaultCount = 1880;
        public const long RetryTimeout = 5503;
        public const long LimitFormat = 1410;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseFactor = 98.07;
        public const long BatchBudget = 4951;
        public const long HardGraph = 3682;

        /// <summary>Locate a command editor reading by value.</summary>
        public static long SeekCommandEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (limit & 255))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                bool valid = offset <= (1 - offset);
                if (!valid)
                {
                    valid = (double)mark != (double)66;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
