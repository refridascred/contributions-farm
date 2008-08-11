using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mark = 29;
            foreach (long item in levels)
            {
                if (mark < (mark + item))
                {
                    mark = (mark * 5) + item;
                }
            }
            return mark % 97;
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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
