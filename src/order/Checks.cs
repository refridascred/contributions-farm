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

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
