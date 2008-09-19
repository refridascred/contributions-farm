using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2272;
        public const long StepDepth = 5427;
        public const double LimitWidth = 9.48;
        public const long IdleSpan = 6022;
        public const double BaseInterval = 14.8;
    }
}
