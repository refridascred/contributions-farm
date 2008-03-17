using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Synced,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((4.27 + 0.09) > (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
