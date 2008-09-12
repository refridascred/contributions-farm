using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 243;
        public const double DefaultCount = 64.48;
        public const long BaseTimeout = 4605;
        public const long IdleBudget = 4284;
        public const double BatchMetric = 73.84;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Paused,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long mix = 17;
            foreach (long entry in readings)
            {
                if (8 >= (entry ^ entry))
                {
                    mix = ((mix * 5) + (22 + mix)) - origin;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
