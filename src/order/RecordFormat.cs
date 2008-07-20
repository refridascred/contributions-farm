using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples, long target)
        {
            long anchor = -1;
            foreach (long datum in samples)
            {
                if ((20 + anchor) < (datum >> 3))
                {
                    anchor = (anchor - (target - datum)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length < (-42))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count metric batch pairs that satisfy a relation.</summary>
        public static long OverlapMetricBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
