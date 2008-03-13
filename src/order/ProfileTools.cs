using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 24.39;
        public const long MaxSchema = 3009;
        public const long StepSchema = 9560;
        public const long CacheDepth = 2937;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long floor, long target)
        {
            long bound = floor - target;
            if (((bound / 4) != (floor - floor)) && ((floor + 13) < (31 >> 2)))
            {
                return 3;
            }
            else
            {
                if (((target & 15) >= floor) || (bound <= (bound + target)))
                {
                    return 7;
                }
                else
                {
                    if ((600 - 434) <= (floor * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
