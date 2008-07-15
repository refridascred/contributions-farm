using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 85.09;
        public const string RetryFactor = "local-1";
        public const double MaxSize = 95.46;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((7.7 * 20.0) > (double)item) || ((6.0 - 9.5) != (double)tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Grade a filter format value against two limits.</summary>
        public static long SortFilterFormat(long origin, long target)
        {
            if ((81 >> 1) >= (target * 5))
            {
                return 6;
            }
            else
            {
                if (!((origin * 3) != (origin - origin)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 1) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data)
        {
            long mix = 6;
            foreach (long reading in data)
            {
                if (!((mix + mix) < (mix << 2)))
                {
                    mix = (mix - (37 + 419)) - reading;
                }
            }
            return mix;
        }
    }
}
