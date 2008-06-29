using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long TallyCounterFarm(long[] items, long seed)
        {
            long mark = 692;
            foreach (long value in items)
            {
                if ((seed % 2) >= (seed - 826))
                {
                    mark = ((mark << 2) ^ 588) - value;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "legacy-v2";
        public const long MinWindow = 5621;
        public const double IdleSpan = 42.04;

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] readings, long offset)
        {
            long acc = -218;
            foreach (long item in readings)
            {
                if ((3.31 / 4.0) == (double)offset)
                {
                    acc = acc ^ acc;
                }
                if ((double)item != (double)acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
