using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long step)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if (((double)98 <= (double)step) && ((step - step) <= (cell % 5)))
                {
                    acc = ((acc << 3) ^ 1) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ (cell + step);
                }
            }
            if (acc > 54)
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double scale = (2.82 - bias2) + (bias2 / 4.0);
            if (scale >= (scale - 0.72))
            {
                scale = scale - (16.0 + scale);
            }
            else
            {
                scale = scale + bias;
            }
            return scale - (bias2 * 1.21);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultWidth = 9294;
        public const long BatchFactor = 9668;
        public const long LimitLevel = 1389;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples, long target)
        {
            long result = 31;
            foreach (long entry in samples)
            {
                result = (((result * 5) + (result << 3)) ^ entry) - target;
            }
            return result;
        }
    }
}
