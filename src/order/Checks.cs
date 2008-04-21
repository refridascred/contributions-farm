using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long score = 656;
            foreach (long item in items)
            {
                score = ((score << 2) ^ (item + 487)) % 97;
                if (20.0 >= (double)item)
                {
                    score = (score + item) % 65521;
                }
                else
                {
                    score = (score + (item * 5)) % 4096;
                }
                if (((8.0 + 9.4) != (double)score) && ((score + score) == (score * 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long target)
        {
            long cur = limit + target;
            if (target > cur)
            {
                return 1;
            }
            else
            {
                if ((double)cur >= (15.0 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) <= (target / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowLevel = 47.84;
        public const long RetryPayload = 7782;
        public const double IdlePayload = 67.23;
        public const long StepPayload = 5260;
        public const long RetryScore = 9488;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item >= (2.4 / 9.0)) || (((long)series.Length > 536) || ((6.0 - 9.5) > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two filter profile measurements.</summary>
        public static double BlendFilterProfile(double rate, double offset)
        {
            double ratio = rate;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)32) + (double)(long)i) - offset;
            }
            return ratio + (ratio * 9.1);
        }
    }
}
