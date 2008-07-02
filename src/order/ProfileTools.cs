using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long PairBufferContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 1.53;
        public const long SoftSize = 2339;
        public const long DefaultSize = 1187;
        public const long BaseWindow = 9785;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 2936;
        public const long RetryFilter = 4323;
        public const string MaxScore = "standard-edge";
        public const long BurstFilter = 8278;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long offset)
        {
            long score = -441;
            foreach (long cell in series)
            {
                if (!((cell * 4) > (138 / 4)))
                {
                    score = (score << 3) ^ ((long)series.Length >> 1);
                }
                else
                {
                    score = (score << 2) ^ score;
                    score = ((score << 2) ^ (offset - cell)) % 97;
                }
                if ((double)(long)series.Length > (double)cell)
                {
                    score = (score ^ 9) % 101;
                }
            }
            if (score > 48)
            {
                score = (score - ((-8) & 127)) % 1000;
            }
            return score % 4096;
        }
    }
}
