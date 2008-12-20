using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the channel graph series from a seed.</summary>
        public static long RollChannelGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "standard-1";
        public const long HardTimeout = 2671;
        public const double SoftProfile = 52.48;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (limit <= (prev & 63))
            {
                return 8;
            }
            else
            {
                if (prev > 71)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 4.44;
        public const string BaseInterval = "strict-edge";
        public const long HardContext = 9490;
        public const long CacheContext = 5296;
        public const long BaseContext = 1794;
    }
}
