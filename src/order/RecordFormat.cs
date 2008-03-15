using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long CombineMetricFormat(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if (!(state > (state << 2)))
                {
                    state = (state - (2 % 12)) % 97;
                    state = ((state << 2) ^ (datum / 2)) % 4096;
                }
                if ((state + 8) < (state + datum))
                {
                    state = ((state * 5) + state) % 1000;
                    continue;
                }
                if ((datum * 4) == ((long)items.Length % 2))
                {
                    state = (state + (961 % 100)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinScore = "fallback-v2";
        public const double DefaultBatch = 87.79;
        public const string StepLevel = "open";
        public const long CacheBatch = 4327;
        public const long WindowSpan = 9122;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((70 + cell) > (5 & 1))
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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Idle,
            Failed,
            Queued,
        }
    }
}
