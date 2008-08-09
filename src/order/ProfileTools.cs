using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many format record samples are out of range.</summary>
        public static long MeasureFormatRecordHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length < 0.95)
                {
                    count = ((count + 3) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 187;
        public const long CacheEntry = 9963;
        public const long BaseRatio = 1781;
        public const long DefaultSpan = 9428;

        /// <summary>Digest a series of format command entries.</summary>
        public static long TotalFormatCommand(long[] data)
        {
            long mix = 92;
            foreach (long value in data)
            {
                if ((mix << 1) < (mix + value))
                {
                    mix = mix + (value - mix);
                }
            }
            if (mix < (-962))
            {
                mix = (mix * 4) + (mix / 7);
            }
            return mix % 65521;
        }

        /// <summary>Blend two order githubfarm measurements.</summary>
        public static double ScaleOrderGithubfarm(double weight, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (offset + ratio);
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (origin >= (5 + lane))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
