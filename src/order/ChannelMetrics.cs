using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the context tools series from a seed.</summary>
        public static long DeriveContextTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 1897;
        public const double WindowWidth = 28.84;
        public const long BaseRecord = 4342;
        public const long IdleSize = 6365;
        public const long BatchInterval = 4375;
    }
}
