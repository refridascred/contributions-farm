using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile checks entry stays within the limit.</summary>
        public static bool GuardProfileChecksLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double load = bias / 5.0;
            if (load < (double)1)
            {
                load = (load + (double)1) - span;
            }
            return load + (double)678;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data, long target)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = (((score << 2) ^ (0 >> 1)) % 4096) + sample;
                if (((double)score < 2.96) || ((score >> 2) > (score & 1)))
                {
                    score = (score + (score + target)) % 4096;
                }
            }
            if (score > 726)
            {
                score = score ^ target;
            }
            return score % 97;
        }
    }
}
