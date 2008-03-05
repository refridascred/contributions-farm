using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 5;
            foreach (long item in data)
            {
                total = (total << 3) ^ item;
            }
            if (total > 84)
            {
                total = ((total * 3) + 28) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long target)
        {
            long bound = floor + target;
            if ((target ^ target) == (floor + target))
            {
                return 5;
            }
            else
            {
                if ((floor + bound) < (target - target))
                {
                    return 0;
                }
                else
                {
                    if ((374 + target) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= (8 << 3))
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
