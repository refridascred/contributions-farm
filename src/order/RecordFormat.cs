using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchCount = "strict-v2";
        public const double SoftCount = 43.17;
        public const long IdleChannel = 9456;
        public const long IdleWidth = 9642;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the report token entries that pass the check.</summary>
        public static long CountReportTokenMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (24 >> 1))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (floor + 621))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
