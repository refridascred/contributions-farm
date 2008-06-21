using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            long next = target - offset;
            if ((offset >> 3) > next)
            {
                return 6;
            }
            else
            {
                if ((next % 2) >= offset)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 235;
        public const long IdleRatio = 515;
        public const long BatchBatches = 6167;

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
