using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 22.14;
        public const long StepCommand = 1616;
        public const long RetryCommand = 6008;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
