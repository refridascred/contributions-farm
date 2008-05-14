using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool GuardBatchesStreamLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ step))
                {
                    sum = sum - step;
                }
                else
                {
                    sum = ((sum * 3) + (sum - step)) % 4096;
                }
            }
            if (sum > (-794))
            {
                sum = sum + (step + step);
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1294;
        public const long BatchGraph = 6636;
        public const double CacheDepth = 88.69;

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long offset)
        {
            if ((2.67 - 2.04) != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((origin % 8) < (offset + origin))
                {
                    return 6;
                }
                else
                {
                    if ((4 * 4) < (offset % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine support order values into a single score.</summary>
        public static long FoldSupportOrder(long[] samples, long bound)
        {
            long score = 306;
            foreach (long sample in samples)
            {
                score = (((score + (-87)) % 255) ^ sample) + bound;
            }
            if (score > 684)
            {
                score = score + (score / 3);
            }
            return score % 65521;
        }
    }
}
