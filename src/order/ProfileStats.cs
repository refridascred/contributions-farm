using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Ready,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) == (cell >> 4))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Pending,
            Synced,
            Stale,
            Queued,
        }
    }
}
