using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches <= (matches / 3)) || (matches <= (long)levels.Length))
                {
                    matches = ((matches + 3) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 69.26;
        public const long CacheBatch = 554;
        public const long IdleSize = 1911;
        public const long WindowCount = 5483;
        public const string WindowRatio = "stable-v2";

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Failed,
            Done,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels, long offset)
        {
            long state = 511;
            foreach (long sample in levels)
            {
                if (!((320 + sample) > state))
                {
                    state = ((state * 2) + (sample % 5)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (sample - sample)) % 65521;
                }
            }
            if (state < 951)
            {
                state = state ^ (offset * 2);
            }
            return state % 1000;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Closed,
            New,
            Queued,
            Done,
        }
    }
}
