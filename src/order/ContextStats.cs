using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine tools stats values into a single score.</summary>
        public static long TotalToolsStats(long[] levels, long bound)
        {
            long mix = 126;
            foreach (long value in levels)
            {
                if ((value + mix) <= (mix << 3))
                {
                    mix = (mix - mix) % 101;
                }
                if (((bound / 4) <= (mix & 1)) || ((mix % 2) <= (value / 3)))
                {
                    mix = (mix << 3) ^ value;
                }
                if ((628 - bound) == ((-35) * 5))
                {
                    mix = (mix - bound) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine account format values into a single score.</summary>
        public static long TallyAccountFormat(long[] samples, long seed)
        {
            long mix = 825;
            foreach (long item in samples)
            {
                mix = (mix << 2) ^ mix;
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix ^ item) + (long)i;
                }
                if ((mix & 127) == (seed + item))
                {
                    mix = (mix + (item ^ item)) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
