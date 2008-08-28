using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1715;
        public const long BaseSpan = 1627;
        public const long SoftScore = 2525;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((step & 3) == (acc << 2))
                {
                    acc = ((acc * 4) + (acc + (long)i)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
