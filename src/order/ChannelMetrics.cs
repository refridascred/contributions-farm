using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 26.95;
        public const long BaseEditor = 1403;
        public const string IdleRatio = "latest";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Idle,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long RollCounterFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor - (seed * 2);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
