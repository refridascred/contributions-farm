using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two session metric measurements.</summary>
        public static double AdjustSessionMetric(double bias, double offset)
        {
            double weight = (double)((-495) % 5);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight - (double)533;
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
