using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 187;
        public const long MaxWidth = 841;
        public const long BurstReport = 586;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Pending,
            Synced,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)5 > (double)step)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
