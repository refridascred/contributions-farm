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

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheDepth = 64.63;
        public const long BaseCount = 3681;
        public const long DefaultFarm = 2807;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long offset)
        {
            if (((step / 7) < (offset - step)) || (offset > (step * 3)))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) < offset)
                {
                    return 0;
                }
                else
                {
                    if (!(3.1 > (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step << 3) >= step) || ((double)offset > (6.0 * 4.01)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
