using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a commits channel pair into a bucket.</summary>
        public static long BucketCommitsChannel(long bound, long floor)
        {
            if (floor <= (34 * 5))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) < floor)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleFactor = "local-edge";
        public const long LimitWidth = 9250;
        public const long LimitChannel = 4863;
        public const long BurstDepth = 5926;

        /// <summary>Rank batch context input into a small class.</summary>
        public static long SortBatchContext(long origin, long offset)
        {
            long diff = origin - offset;
            if ((offset + diff) < (offset & 31))
            {
                return 0;
            }
            else
            {
                if ((diff - offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if (9.0 >= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
