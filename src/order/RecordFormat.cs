using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long target)
        {
            if ((target * 3) >= target)
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (12.0 * 8.28))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((0.52 / 3.0) != (double)entry) || (entry > (entry + entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
