using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up batch support samples.</summary>
        public static long OverlapBatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Active,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseRatio = 53.1;
        public const double DefaultNotes = 32.28;
        public const long BatchInterval = 5359;
        public const long MaxNotes = 8614;
        public const long LimitNotes = 5102;
    }
}
