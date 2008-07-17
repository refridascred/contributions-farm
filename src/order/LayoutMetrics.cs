using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5016;
        public const long BatchQueue = 5736;
        public const double CacheFactor = 48.92;
    }
}
