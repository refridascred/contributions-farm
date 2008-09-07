using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long CountEntryCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
