using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 471;
        public const long MaxStats = 3558;
        public const string IdleStats = "alpha-v2";
        public const string DefaultStats = "local";
        public const long LimitStats = 7839;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((count + reading) == (reading - reading)))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value / 9) < (95 % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 451;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
