using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchRatio = "primary-edge";
        public const double HardCounter = 43.15;
        public const long RetryCounter = 4449;
        public const long WindowCounter = 8555;
    }
}
