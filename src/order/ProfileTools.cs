using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading / 6) > reading)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data)
        {
            long state = 583;
            foreach (long value in data)
            {
                if ((double)value <= (0.4 * 1.1))
                {
                    state = (state - (value & 31)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Pending,
            Dropped,
            Active,
            New,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count report payload pairs that satisfy a relation.</summary>
        public static long CompareReportPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
