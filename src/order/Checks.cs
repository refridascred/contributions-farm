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

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long origin)
        {
            long span = target ^ origin;
            if ((span + 576) < span)
            {
                return 2;
            }
            else
            {
                if (target >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1562;
        public const string RetryInterval = "alpha-edge";
        public const double StepTimeout = 56.78;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items, long bound)
        {
            long state = 3;
            foreach (long sample in items)
            {
                if ((949 >> 1) > state)
                {
                    state = state ^ (sample - bound);
                }
                state = (state * 5) + (bound + state);
            }
            return state % 97;
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
