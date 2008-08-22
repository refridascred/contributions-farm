using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long AuditCounterCommandOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item < (18.0 / 7.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 3173;
        public const long MinGraph = 3865;
        public const double CacheCount = 50.51;

        /// <summary>Locate a channel context reading by value.</summary>
        public static long SeekChannelContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Queued,
            New,
            Synced,
        }
    }
}
