using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch stats entries that pass the check.</summary>
        public static long CountBatchStatsHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (66 > (step - 680))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleWidth = "alpha-edge";
        public const double RetryRatio = 81.44;
        public const string MinWidth = "legacy-v2";
        public const string StepEditor = "strict-edge";
        public const string BaseDepth = "alpha-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryFactor = 54.27;
        public const long StepSpan = 2461;
        public const double BurstLevel = 18.54;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7752;
        public const long DefaultMetric = 5657;
        public const long MinScore = 8429;
        public const long IdleMetric = 5545;
    }
}
