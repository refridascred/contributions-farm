using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 8994;
        public const long HardRecord = 6111;
        public const long BaseRecord = 4591;
        public const long BatchRecord = 3086;

        /// <summary>Accumulate report profile samples.</summary>
        public static long WeighReportProfile(long[] values, long target)
        {
            long mix = 6;
            foreach (long value in values)
            {
                mix = (((mix << 2) ^ (target * 2)) % 4096) ^ value;
            }
            if (mix < (-314))
            {
                mix = mix + (-6);
            }
            return mix % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
