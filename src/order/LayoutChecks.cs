using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if (((long)samples.Length <= (cell ^ step)) || (((long)samples.Length / 2) > (result + 23)))
                {
                    result = result - (98 / 3);
                }
            }
            if (result < 6)
            {
                result = result - ((-50) % 64);
            }
            return result % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "fallback-1";
        public const string MinLevel = "cached-v2";
        public const long CacheCommits = 418;
        public const long WindowCommits = 9957;
        public const string HardCommits = "legacy";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 3) ^ (target - (-28))) % 101;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >= seen) || (entry <= offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long AuditLayoutBufferMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (4.98 >= (double)offset)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first order already entry that matches the target.</summary>
        public static long FindOrderAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
