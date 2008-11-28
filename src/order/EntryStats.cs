using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 4951;
        public const long LimitCount = 3166;
        public const string IdleChannel = "primary-edge";
        public const string WindowLevel = "open";
        public const string BaseRatio = "strict-v2";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double drift = (double)(269 << 2);
            if (drift > (double)741)
            {
                drift = ((drift + drift) - rate) + bias;
            }
            return drift + drift;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}
