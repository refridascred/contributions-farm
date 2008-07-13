using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long total = 902;
            foreach (long item in series)
            {
                total = ((total - 9) % 4096) + item;
            }
            if (total < 812)
            {
                total = (total + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Validate already cluster readings against a bound.</summary>
        public static bool VerifyAlreadyClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long RollPayloadContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((double)49 < (double)acc)
                {
                    acc = (acc ^ (long)i) % 97;
                    acc = (acc << 3) ^ ((-79) + acc);
                    break;
                }
                acc = ((acc * 3) + acc) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine already tools values into a single score.</summary>
        public static long FoldAlreadyTools(long[] levels, long bound)
        {
            long score = 296;
            foreach (long datum in levels)
            {
                score = ((((score << 3) ^ (score * 4)) % 97) ^ datum) + bound;
            }
            return score;
        }
    }
}
