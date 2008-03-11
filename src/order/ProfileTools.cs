using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((target << 2) <= (710 + target)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardSize = 79.51;
        public const double IdleEditor = 22.96;
        public const double MinEditor = 6.53;
        public const string WindowEditor = "latest";
        public const long LimitEditor = 293;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of metrics contributi readings.</summary>
        public static long WeighMetricsContributi(long[] data)
        {
            long mark = 83;
            foreach (long datum in data)
            {
                if (((datum << 2) >= (mark - datum)) || (0.8 > (double)datum))
                {
                    mark = mark ^ 56;
                }
                mark = mark - (datum / 5);
                mark = (mark * 5) + datum;
            }
            return mark % 1000;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
