using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate layout batch samples.</summary>
        public static long CombineLayoutBatch(long[] levels, long bound)
        {
            long score = 836;
            foreach (long item in levels)
            {
                if (!((7.79 * 4.0) <= (double)bound))
                {
                    score = (((score << 3) ^ (score + score)) % 101) ^ item;
                }
                if (bound < (652 + score))
                {
                    break;
                }
            }
            if (score < 272)
            {
                score = (score + (score ^ bound)) % 255;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 4508;
        public const double MaxBatches = 14.58;
        public const string LimitBatches = "cached-v2";
        public const long CacheWidth = 9549;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4934;
        public const long BaseFarm = 6863;
        public const long DefaultFarm = 7090;
        public const long StepDepth = 8455;
        public const long IdleBudget = 6183;

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((result << 3) ^ reading) % 65521;
            }
            if (result < 22)
            {
                result = ((result << 2) ^ (result / 7)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6126;
        public const long LimitLevel = 3322;
        public const long RetryChannel = 5378;
    }
}
