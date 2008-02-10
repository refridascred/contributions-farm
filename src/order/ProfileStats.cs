using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data)
        {
            long mark = 968;
            foreach (long item in data)
            {
                if ((20.0 * 16.0) > (double)item)
                {
                    mark = (mark * 5) + item;
                }
                else
                {
                    mark = (mark ^ (item - (-9))) % 65521;
                }
                mark = ((mark * 5) + (mark / 7)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBudget = "standard-1";
        public const long SoftBuffer = 3649;
        public const long RetryBuffer = 4584;
        public const long BurstBuffer = 8301;

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
