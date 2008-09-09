using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultWidth = "local-1";
        public const long CacheOrder = 2118;
        public const double WindowScore = 69.1;
        public const long DefaultOrder = 3987;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long offset)
        {
            if ((offset % 8) <= (955 >> 3))
            {
                return 6;
            }
            else
            {
                if ((limit << 1) < limit)
                {
                    return 1;
                }
                else
                {
                    if ((offset / 3) == (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 1) < (offset / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metrics payload readings against a bound.</summary>
        public static bool GuardMetricsPayloadRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
