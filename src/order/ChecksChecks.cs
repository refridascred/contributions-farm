using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Measure how many farm editor samples are out of range.</summary>
        public static long AuditFarmEditorMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((555 + (long)readings.Length) < hits)
                {
                    hits = ((hits + 2) + reading) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 5398;
        public const long StepContext = 1465;
        public const long BurstDepth = 9751;
        public const string IdleContext = "local-edge";
    }
}
