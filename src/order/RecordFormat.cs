using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first stream window entry that matches the target.</summary>
        public static long LocateStreamWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long IterateSchemaAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 3) ^ (anchor << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of account token readings.</summary>
        public static long TotalAccountToken(long[] samples)
        {
            long score = -174;
            foreach (long reading in samples)
            {
                score = (score + (reading >> 4)) % 4096;
                score = ((score << 3) ^ (score + 436)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Synced,
            Paused,
            Draft,
            Closed,
        }
    }
}
