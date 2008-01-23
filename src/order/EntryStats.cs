using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mark = 31;
            foreach (long cell in levels)
            {
                if ((2 + mark) < (cell - mark))
                {
                    mark = (mark - cell) % 4096;
                    mark = (mark + (4 - 6)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (8 - mark)) % 97;
                }
                mark = (mark - (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long CombineBatchCluster(long[] samples, long floor)
        {
            long anchor = 89;
            foreach (long entry in samples)
            {
                if (entry >= (-1))
                {
                    anchor = (anchor ^ (anchor % 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (floor * 4)) % 255;
                }
            }
            if (anchor > 293)
            {
                anchor = anchor - (0 << 1);
            }
            return anchor % 65521;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
