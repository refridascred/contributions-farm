using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up batch layout samples.</summary>
        public static long MatchBatchLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6.2 + 0.85) < (double)count)
                {
                    count = ((count + 1) + value) + step;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxSpan = "alpha-edge";
        public const string MinLevel = "primary-1";
        public const double CacheEntry = 83.7;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen / 6) >= entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long origin, long step)
        {
            long delta = origin ^ step;
            if (!(65 < (delta & 31)))
            {
                return 6;
            }
            else
            {
                if (((-70) << 1) == (step + 165))
                {
                    return 5;
                }
                else
                {
                    if (((double)step == (9.77 / 5.0)) || ((14 / 5) <= delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (delta % 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
