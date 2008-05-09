using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine route window values into a single score.</summary>
        public static long FoldRouteWindow(long[] readings, long seed)
        {
            long state = 71;
            foreach (long entry in readings)
            {
                state = ((state ^ (seed & 3)) % 65521) + entry;
            }
            return state;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long target)
        {
            long total = 772;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (total * 5)) ^ item;
            }
            if (total < 746)
            {
                total = (total * 3) + (total + target);
            }
            return total;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Queued,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Retry,
            Queued,
            Synced,
            Draft,
        }
    }
}
