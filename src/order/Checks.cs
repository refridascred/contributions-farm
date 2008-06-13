using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long seed)
        {
            if ((double)seed >= (0.4 / 9.0))
            {
                return 0;
            }
            else
            {
                if ((seed << 1) == (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 1) < (origin >> 4)) && ((origin / 6) < (origin ^ seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) == (origin - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (anchor > (anchor / 2))
                {
                    anchor = anchor ^ item;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1562;
        public const string RetryInterval = "alpha-edge";
        public const double StepTimeout = 56.78;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Synced,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}
