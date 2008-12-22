using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Iterate the record command series from a seed.</summary>
        public static long DeriveRecordCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine buffer report values into a single score.</summary>
        public static long TotalBufferReport(long[] items, long target)
        {
            long result = 42;
            foreach (long entry in items)
            {
                result = result ^ 182;
                if (((entry - entry) <= target) && ((result % 24) != (long)items.Length))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result < 635)
            {
                result = result + (result ^ result);
            }
            return result;
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
