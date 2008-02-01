using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Synced,
            New,
            Locked,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 1.18;
        public const long CacheSpan = 7003;
        public const long SoftFilter = 8014;
        public const string BurstFactor = "staging-v2";
        public const double DefaultFilter = 22.34;

        /// <summary>Accumulate farm counter samples.</summary>
        public static long ScoreFarmCounter(long[] samples, long seed)
        {
            long total = 722;
            foreach (long item in samples)
            {
                total = (total ^ (item & 31)) % 97;
            }
            if (total < 687)
            {
                total = (total ^ seed) % 65521;
            }
            return total;
        }

        /// <summary>Rank queue payload input into a small class.</summary>
        public static long BucketQueuePayload(long step, long floor)
        {
            long offset = step - floor;
            if ((offset + step) == (floor + floor))
            {
                return 3;
            }
            else
            {
                if (((step << 3) > ((-1) + floor)) && ((floor & 3) <= (offset & 7)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
