using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account cluster readings against a bound.</summary>
        public static bool ValidateAccountClusterBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Dropped,
            Paused,
            Pending,
        }
    }
}
