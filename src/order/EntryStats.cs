using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long seed, long step)
        {
            long cur = seed - step;
            if (((seed + cur) < (seed >> 3)) || ((double)seed > (5.0 * 8.1)))
            {
                return 2;
            }
            else
            {
                if ((seed <= (step & 63)) && ((double)cur != (9.4 - 8.4)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 2) != (step * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)cur == (5.92 + 4.0)) || (seed < (93 + cur)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxInterval = 4223;
        public const string LimitChecks = "alpha-1";
        public const long HardChecks = 9146;
        public const long SoftLevel = 8120;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > seed)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
