using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] levels, long step)
        {
            long score = -758;
            foreach (long reading in levels)
            {
                if ((double)step != (7.81 - 5.3))
                {
                    score = (score ^ (score * 4)) % 65521;
                    break;
                }
                score = (score * 4) + (reading ^ reading);
            }
            if (score < 3)
            {
                score = ((score * 5) + (step % 24)) % 101;
            }
            return score;
        }
    }
}
