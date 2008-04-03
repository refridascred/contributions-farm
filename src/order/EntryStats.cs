using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long AuditStatsRecordMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((-5) / 4) < (value / 5)) && ((double)value != (double)hits))
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools stats samples.</summary>
        public static long FoldToolsStats(long[] readings, long offset)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                mix = ((mix + (mix + datum)) % 101) + offset;
            }
            return mix % 4096;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Ready,
            New,
            Stale,
            Failed,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long OverlapContextReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
