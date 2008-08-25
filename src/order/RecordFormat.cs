using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long AuditStatsChannelHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + 551) <= (step - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 1455;
        public const long BurstDepth = 6699;
        public const double MinRatio = 15.81;
        public const long StepSupport = 4723;

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 1984;
        public const long BurstFactor = 8667;
        public const long MinWidth = 5815;
        public const long BatchScore = 6853;
        public const long LimitBatch = 2580;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
