using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(hits > (entry << 1)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9218;
        public const string IdleSize = "strict";
        public const long MaxSpan = 3468;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up account batches samples.</summary>
        public static long PairAccountBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
