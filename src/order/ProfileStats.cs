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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)origin <= (8.04 + 5.3))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 3303;
        public const long BurstRatio = 5054;
        public const long MaxScore = 3504;
        public const long LimitFilter = 9091;
    }
}
