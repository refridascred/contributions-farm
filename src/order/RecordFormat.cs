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

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long floor)
        {
            long sum = 755;
            foreach (long item in values)
            {
                if (5 > (sum % 5))
                {
                    sum = ((sum - (183 << 1)) + item) + floor;
                }
            }
            return sum;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((1.8 - 4.47) < (double)matches)
                {
                    matches = ((matches + 2) + item) - target;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
