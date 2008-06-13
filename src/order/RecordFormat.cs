using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up graph counter samples.</summary>
        public static long OverlapGraphCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor graph samples are out of range.</summary>
        public static long AuditEditorGraphGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell >> 5) < (19 ^ seen)) || ((seen % 2) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((5.0 + 2.7) <= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks contributi sample.</summary>
        public static long LocateChecksContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 7872;
        public const string MaxFormat = "fallback-edge";
        public const long BaseSpan = 3800;
        public const long HardFormat = 8794;
        public const long RetryTimeout = 3225;
    }
}
