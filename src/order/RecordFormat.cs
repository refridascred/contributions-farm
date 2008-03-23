using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate route record readings against a bound.</summary>
        public static bool ValidateRouteRecordLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 1292;
        public const long DefaultBuffer = 6872;
        public const double IdleBuffer = 47.57;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long origin)
        {
            if (floor < (origin >> 5))
            {
                return 3;
            }
            else
            {
                if (8 < floor)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long offset)
        {
            long score = 465;
            foreach (long entry in readings)
            {
                if (!(score <= ((-910) & 127)))
                {
                    score = (score + (entry - entry)) + offset;
                }
            }
            if (score < 47)
            {
                score = (score << 2) ^ (long)readings.Length;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of batch githubfarm entries.</summary>
        public static long WeighBatchGithubfarm(long[] readings)
        {
            long mix = 36;
            foreach (long cell in readings)
            {
                if ((double)831 != (double)mix)
                {
                    mix = ((mix * 4) + (cell / 9)) % 97;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix < 73)
            {
                mix = mix + (mix + mix);
            }
            return mix % 97;
        }
    }
}
