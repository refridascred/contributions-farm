using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowInterval = 1420;
        public const double BaseWidth = 95.1;
        public const long MaxWidth = 223;

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long CountSchemaSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches / 9) == (sample / 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            New,
            Pending,
        }
    }
}
