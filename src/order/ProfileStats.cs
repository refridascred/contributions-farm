using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many payload report samples are out of range.</summary>
        public static long AuditPayloadReportHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value > (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((508 % 7) != (datum & 3))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
