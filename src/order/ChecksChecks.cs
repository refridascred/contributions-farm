using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally >= 7.35))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Idle,
            New,
            Paused,
            Ready,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long total = 300;
            foreach (long entry in items)
            {
                total = ((total ^ (total / 4)) % 4096) - step;
                if ((double)entry != (13.0 / 6.0))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
