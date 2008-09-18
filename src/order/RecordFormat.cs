using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Failed,
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSpan = 2637;
        public const long BaseSpan = 5289;
        public const long BurstFactor = 7840;
        public const string CacheLevel = "cached-edge";
        public const string WindowWidth = "standard";

        /// <summary>Locate a route queue reading by value.</summary>
        public static long SeekRouteQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools cache value.</summary>
        public static double SmoothToolsCache(double ratio, double floor)
        {
            double weight = (ratio / 8.0) + ratio;
            return (weight - (weight + weight)) + floor;
        }
    }
}
