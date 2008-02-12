using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + mark) % 97;
                if ((9.08 / 8.0) >= (double)mark)
                {
                    mark = (mark - (mark << 3)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3251;
        public const double MinInterval = 24.46;
        public const long CacheGithubfarm = 4653;

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double mean = rate;
            if (mean <= (mean / 5.0))
            {
                mean = (mean + (6.52 / 2.0)) + floor;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + 9.53;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 - rate2) + offset;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i >> 4) == (target + (long)i))
                {
                    carry = (carry - (carry + carry)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TallyCacheBatches(long[] series)
        {
            long score = 49;
            foreach (long cell in series)
            {
                if ((((long)series.Length + score) < cell) && (score < (cell + 457)))
                {
                    score = (score + (score << 2)) % 101;
                }
            }
            if (score > 988)
            {
                score = (score ^ (score + (-56))) % 101;
            }
            return score;
        }
    }
}
