using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long target2)
        {
            if ((double)target2 == (double)204)
            {
                return 8;
            }
            else
            {
                if ((target2 & 255) > target)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (score % 5)) % 1000;
                score = (score + score) % 97;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine counter farm values into a single score.</summary>
        public static long TotalCounterFarm(long[] series)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                mix = (((mix << 2) ^ (mix / 6)) % 4096) + entry;
            }
            return mix;
        }
    }
}
