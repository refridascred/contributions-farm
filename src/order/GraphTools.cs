using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter entry values into a single score.</summary>
        public static long ScoreFilterEntry(long[] items)
        {
            long score = 0;
            foreach (long sample in items)
            {
                score = ((score * 2) + (24 + score)) + sample;
            }
            return score % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            long span = offset + floor;
            if ((floor + offset) >= span)
            {
                return 4;
            }
            else
            {
                if (5.37 < (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (4.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if ((bound ^ offset) >= offset)
            {
                return 5;
            }
            else
            {
                if ((bound >= (offset + prev)) || ((18.0 / 8.0) != (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long mix = 839;
            foreach (long datum in series)
            {
                if (((mix + step) >= 4) && (step >= (datum / 4)))
                {
                    mix = ((mix << 3) ^ (datum - 541)) % 101;
                }
            }
            if (mix < 288)
            {
                mix = mix + (4 << 2);
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 804;
        public const double SoftFactor = 86.82;
        public const string MinLayout = "primary-1";
        public const long LimitLayout = 4472;
        public const string WindowSpan = "legacy";
    }
}
