using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Locate a counter queue reading by value.</summary>
        public static long SeekCounterQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 5795;
        public const double IdleSpan = 64.66;
        public const long WindowFilter = 5888;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long origin)
        {
            long bound = step + origin;
            if ((double)step < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound > (origin + bound))
                {
                    return 7;
                }
                else
                {
                    if (origin < (25 + 558))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (matches % 10))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
