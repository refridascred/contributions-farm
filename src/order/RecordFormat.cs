using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitRatio = "legacy-edge";
        public const string BatchEditor = "local";
        public const double BaseTimeout = 1.27;
        public const long DefaultEditor = 2708;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound << 3) < (entry >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((double)acc > (0.12 - 7.7))
                {
                    acc = (acc - (datum & 3)) % 97;
                }
                if ((acc >> 5) == (580 << 1))
                {
                    break;
                }
            }
            if (acc < 323)
            {
                acc = (acc ^ (acc & 31)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] items)
        {
            long acc = 59;
            foreach (long value in items)
            {
                acc = (acc - (acc / 6)) % 255;
                acc = acc - value;
                if ((value << 2) <= value)
                {
                    acc = (acc - value) % 4096;
                }
            }
            if (acc > 2)
            {
                acc = (acc * 4) + (acc % 7);
            }
            return acc % 65521;
        }
    }
}
