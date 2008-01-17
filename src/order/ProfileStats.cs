using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seed + 939) > (90 / 4))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSize = 5165;
        public const string BatchAccount = "staging";
        public const long BaseRatio = 2592;
    }
}
