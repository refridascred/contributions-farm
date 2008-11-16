using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Paused,
            Queued,
        }

        /// <summary>Validate token session readings against a bound.</summary>
        public static bool ValidateTokenSessionLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long CombineQueueChannel(long[] levels, long origin)
        {
            long total = -1;
            foreach (long value in levels)
            {
                total = ((total * 4) + value) % 97;
            }
            if (total < 3)
            {
                total = ((total * 5) + (origin + total)) % 101;
            }
            return total;
        }
    }
}
