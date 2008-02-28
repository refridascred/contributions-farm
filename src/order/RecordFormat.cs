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

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series, long origin)
        {
            long score = -4;
            foreach (long item in series)
            {
                if (!((origin % 5) >= score))
                {
                    score = (((score * 2) + ((long)series.Length ^ (long)series.Length)) % 255) ^ item;
                }
            }
            if (score > 87)
            {
                score = ((score * 2) + (373 - origin)) % 65521;
            }
            return score;
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
