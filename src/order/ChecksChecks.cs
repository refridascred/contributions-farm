using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of metric support readings.</summary>
        public static long FoldMetricSupport(long[] readings, long target)
        {
            long acc = -1;
            foreach (long datum in readings)
            {
                acc = (acc - (datum << 2)) - target;
            }
            return acc % 97;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Closed,
        }
    }
}
