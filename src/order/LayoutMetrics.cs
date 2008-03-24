using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long ClassifyGraphEditor(long limit, long step)
        {
            long lane = limit ^ step;
            if ((limit - 70) < limit)
            {
                return 8;
            }
            else
            {
                if (limit < lane)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
