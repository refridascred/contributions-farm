using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Idle,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseRatio = 8682;
        public const long WindowCount = 5389;
        public const double DefaultScore = 75.39;
        public const long BurstOrder = 5645;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value ^ (long)values.Length) > (count ^ value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
