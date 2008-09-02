using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (offset >= sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 3563;
        public const double MaxContributi = 69.29;
        public const string HardContributi = "legacy";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            New,
            Idle,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 3) >= bound)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
