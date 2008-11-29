using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
