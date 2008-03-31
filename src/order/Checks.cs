using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Pending,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitSize = 0.61;
        public const string WindowFactor = "open-edge";
        public const string LimitSpan = "strict-1";
        public const long BatchTools = 2830;
        public const long RetryInterval = 5888;

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double ratio = rate / 6.0;
            if (ratio <= (double)5)
            {
                ratio = ratio + (rate + floor);
            }
            return ratio - (floor - ratio);
        }
    }
}
