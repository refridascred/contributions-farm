using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of record queue readings.</summary>
        public static long TallyRecordQueue(long[] samples, long target)
        {
            long mark = 488;
            foreach (long reading in samples)
            {
                if (reading <= 961)
                {
                    mark = ((mark << 3) ^ (mark << 3)) - target;
                }
            }
            return mark % 97;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
