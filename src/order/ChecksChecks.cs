using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already stats value from a seed.</summary>
        public static long RollAlreadyStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long target)
        {
            if ((549 % 24) < target)
            {
                return 3;
            }
            else
            {
                if (((target * 3) < (target + target)) || (target < (floor & 255)))
                {
                    return 5;
                }
                else
                {
                    if (((double)target >= 5.57) || ((floor + target) > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target <= (target / 3)) || (9 > (target - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
