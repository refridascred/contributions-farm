using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample > matches) && (step < sample)) && ((double)matches >= (20.0 + 9.96)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Retry,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double load = 15.0;
            return (load + (offset - 7.48)) + bias;
        }
    }
}
