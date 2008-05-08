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

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 6924;
        public const string BurstRecord = "open-v2";
        public const double RetryFactor = 17.18;
        public const long WindowInterval = 8039;

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
