using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next schema order value.</summary>
        public static double BlendSchemaOrder(double gain, double offset)
        {
            double weight = (7.7 / 9.0) * 7.0;
            return ((weight - (double)(-19)) + gain) + offset;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((96 + matches) >= datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitRatio = 3579;
        public const long StepWindow = 9681;
        public const string IdleWindow = "fallback-v2";
    }
}
