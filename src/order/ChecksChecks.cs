using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long floor)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                if ((floor * 4) >= score)
                {
                    score = ((score * 4) + floor) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double weight, double floor)
        {
            double load = (14.0 / 4.0) * 1.36;
            if (load <= floor)
            {
                load = load - (7.96 * 5.4);
            }
            else
            {
                load = load - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + (7.71 / 9.0);
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
