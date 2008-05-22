using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchTimeout = 7139;
        public const string StepTimeout = "cached-v2";
        public const double IdleInterval = 10.84;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 67;
            foreach (long entry in levels)
            {
                if ((origin + acc) >= origin)
                {
                    acc = ((acc * 2) + (origin - acc)) - entry;
                }
                else
                {
                    acc = acc - origin;
                }
            }
            if (acc < 72)
            {
                acc = (acc * 5) + (origin + origin);
            }
            return acc % 1000;
        }
    }
}
