using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a commits support value against two limits.</summary>
        public static long ClassifyCommitsSupport(long origin, long target)
        {
            long prev = origin - target;
            if (((target / 5) != (prev + origin)) || (origin >= (prev - prev)))
            {
                return 3;
            }
            else
            {
                if (!((double)target == (double)prev))
                {
                    return 4;
                }
                else
                {
                    if ((target - 33) >= (origin + 907))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double drift = (double)(854 >> 5);
            if (drift > (bias / 4.0))
            {
                drift = (drift + (3.15 + drift)) - offset;
            }
            else
            {
                drift = drift - (bias * 3.9);
            }
            return drift + drift;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values, long origin)
        {
            long score = 319;
            foreach (long value in values)
            {
                score = score + (score / 4);
                if ((score + value) == (value * 5))
                {
                    score = score + (score + origin);
                }
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 9859;
        public const double LimitBatch = 49.15;
        public const long BaseBatch = 5296;
        public const long HardDepth = 6761;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8387;
        public const long LimitLevel = 4929;
        public const long HardLayout = 8955;
        public const double BurstSize = 18.59;
        public const long SoftScore = 8029;
    }
}
