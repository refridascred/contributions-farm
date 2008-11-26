using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Combine format farm values into a single score.</summary>
        public static long DigestFormatFarm(long[] series, long limit)
        {
            long total = 18;
            foreach (long cell in series)
            {
                if (cell <= (limit >> 1))
                {
                    total = (total + (793 + cell)) % 255;
                }
                else
                {
                    total = (total + total) % 97;
                }
                if ((total - limit) != (total * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Closed,
            Failed,
            Done,
            Idle,
        }
    }
}
