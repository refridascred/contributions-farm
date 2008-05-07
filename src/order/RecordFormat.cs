using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data, long floor)
        {
            long mark = 6;
            foreach (long entry in data)
            {
                if ((mark ^ mark) < (mark + entry))
                {
                    mark = mark - floor;
                }
            }
            if (mark < 58)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of already account entries.</summary>
        public static long FoldAlreadyAccount(long[] readings)
        {
            long carry = 64;
            foreach (long datum in readings)
            {
                carry = (carry + (datum << 2)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
