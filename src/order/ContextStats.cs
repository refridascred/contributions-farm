using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2769;
        public const double HardCount = 20.31;
        public const string IdleProfile = "local-1";
        public const string MinScore = "staging-1";

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long limit)
        {
            long offset = origin + limit;
            if (((23 + limit) == (limit + 481)) && ((3.39 + 3.56) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if (origin > (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Pending,
            Done,
            New,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long bound, long floor)
        {
            long slot = bound + floor;
            if (slot >= (slot - bound))
            {
                return 7;
            }
            else
            {
                if ((floor % 10) > (floor - slot))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 97) <= (slot & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.7 + 0.2) <= (double)slot)
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
        }
    }
}
