using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length & 7) > datum)
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

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples, long floor)
        {
            long anchor = -77;
            foreach (long cell in samples)
            {
                if (97 < (floor % 2))
                {
                    anchor = anchor + cell;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 26.9;
        public const double MinCache = 27.21;
        public const long BatchCache = 139;
        public const long SoftCache = 6487;
    }
}
