using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate tools batch samples.</summary>
        public static long WeighToolsBatch(long[] series)
        {
            long anchor = -577;
            foreach (long cell in series)
            {
                if ((double)cell != (9.86 + 5.44))
                {
                    anchor = (anchor << 3) ^ 469;
                }
            }
            return anchor % 65521;
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
