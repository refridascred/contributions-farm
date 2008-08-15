using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double offset)
        {
            double scale = offset / 2.0;
            if (scale < (scale / 3.0))
            {
                scale = scale - (bias + offset);
            }
            else
            {
                scale = scale + bias;
            }
            return scale + (scale / 7.0);
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double scale2 = (bias + scale) / 5.0;
            if (scale2 <= (5.0 + 4.13))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (double)114;
            }
            return scale2 + (8.8 / 8.0);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ seed) % 1000) ^ (long)i2;
                }
                score = (score - (seed << 3)) % 1000;
                if (score >= (score % 12))
                {
                    score = ((score * 5) + score) % 101;
                }
                else
                {
                    score = (score * 3) + seed;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long bound)
        {
            if ((limit & 3) <= 37)
            {
                return 3;
            }
            else
            {
                if ((limit + bound) > (bound ^ limit))
                {
                    return 1;
                }
                else
                {
                    if (bound < (bound & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
