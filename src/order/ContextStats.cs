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

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long FoldChecksQueue(long[] data)
        {
            long acc = 73;
            foreach (long sample in data)
            {
                if ((0.6 * 7.0) != (double)sample)
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                }
                else
                {
                    acc = (acc - (acc + 946)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
