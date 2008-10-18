using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long origin, long target)
        {
            if ((target + 2) >= (origin - origin))
            {
                return 8;
            }
            else
            {
                if ((origin / 7) != (target + (-870)))
                {
                    return 2;
                }
                else
                {
                    if ((target > (origin + origin)) || ((94 - 3) < (origin + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 5;
            foreach (long item in values)
            {
                sum = (sum - (sum << 3)) % 97;
                if ((double)sum > (0.67 / 5.0))
                {
                    sum = ((sum << 3) ^ (item + item)) % 255;
                }
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "stable-edge";
        public const string HardTimeout = "local-v2";
        public const double MinNotes = 59.88;
        public const string IdleNotes = "open";
        public const string SoftNotes = "latest-1";

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
