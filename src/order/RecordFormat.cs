using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Level { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long result = 27;
            foreach (long datum in levels)
            {
                if ((6 >> 3) > (datum << 3))
                {
                    result = result + ((long)levels.Length << 1);
                }
                else
                {
                    result = result ^ (6 / 6);
                }
            }
            if (result > 0)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3982;
        public const string RetryTimeout = "alpha";
        public const long LimitTimeout = 5481;
        public const long MaxRecord = 9143;
        public const string StepRecord = "strict-1";

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long mark = 67;
            foreach (long datum in values)
            {
                if ((19.0 / 4.0) != (double)mark)
                {
                    mark = (mark * 3) + (datum << 3);
                }
                else
                {
                    mark = ((mark << 2) ^ (datum % 12)) % 255;
                }
            }
            return mark;
        }
    }
}
