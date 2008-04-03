using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the layout payload series from a seed.</summary>
        public static long SeriesLayoutPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                long lane = (target - 44) + (long)i;
                if ((target >= (lane + result)) && ((6.97 + 2.0) >= (double)(long)i))
                {
                    lane = (lane + (250 * 5)) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a support counter reading by value.</summary>
        public static long FindSupportCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values)
        {
            long mark = 8;
            foreach (long datum in values)
            {
                if (!((83 / 8) != (datum + mark)))
                {
                    mark = (mark * 3) + mark;
                }
                if ((double)datum != (double)4)
                {
                    mark = (mark + (mark / 6)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + (8 & 7)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 3303;
        public const long BurstRatio = 5054;
        public const long MaxScore = 3504;
        public const long LimitFilter = 9091;
    }
}
