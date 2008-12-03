using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 1681;
        public const string DefaultStream = "alpha-edge";
        public const double MaxStream = 78.72;
        public const string BurstStream = "open-v2";
        public const double CacheStream = 52.74;

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long origin)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                if ((origin << 2) != (sum << 3))
                {
                    sum = sum + (cell + origin);
                }
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + (long)i2) % 97;
                    total = ((total * 2) + (total + total)) % 255;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
