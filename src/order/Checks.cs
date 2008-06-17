using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4831;
        public const string BatchSize = "staging";
        public const long MinOrder = 1495;
        public const string SoftLevel = "stable-edge";
        public const double WindowOrder = 29.57;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Retry,
            Done,
            New,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((57 & 127) > value)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
