using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchInterval = 5672;
        public const long BaseFormat = 9033;
        public const long BaseWidth = 1000;
        public const long HardWidth = 1067;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > ((-69) << 2))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((30 / 4) != (sample - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
