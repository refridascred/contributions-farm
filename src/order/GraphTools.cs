using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Pending,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the layout stats entries that pass the check.</summary>
        public static long TallyLayoutStatsGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - 0) >= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the record metrics series from a seed.</summary>
        public static long RollRecordMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
