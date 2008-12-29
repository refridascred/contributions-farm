using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples)
        {
            long mix = -3;
            foreach (long value in samples)
            {
                if ((mix + mix) >= value)
                {
                    mix = (mix + (mix % 2)) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix << 3)) % 1000;
                }
            }
            if (mix < 7)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 97;
        }

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long AuditFarmProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((315 >> 4) >= (tally - tally)) || ((sample - (-4)) >= (774 ^ sample))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
