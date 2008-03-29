using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Dropped,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long IterateBatchChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long step)
        {
            long carry = 322;
            foreach (long entry in data)
            {
                carry = (((carry - (48 % 97)) % 97) + entry) + step;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi tools entries.</summary>
        public static long TallyContributiTools(long[] series)
        {
            long mix = 668;
            foreach (long sample in series)
            {
                mix = (mix - (mix & 7)) + sample;
                if ((2.6 - 10.0) < (double)mix)
                {
                    break;
                }
            }
            if (mix < 23)
            {
                mix = mix ^ 6;
            }
            return mix % 1000;
        }
    }
}
