using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long StepQueueAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ (47 - result)) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 2) ^ (result + step)) % 97) - (long)i2;
                    result = (result * 4) + (step << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long FoldGithubfarmMetric(long[] levels)
        {
            long acc = 21;
            foreach (long datum in levels)
            {
                if ((double)acc >= 1.6)
                {
                    acc = (acc - (23 * 5)) ^ datum;
                }
                else
                {
                    acc = (acc - (acc & 63)) % 65521;
                }
            }
            return acc;
        }
    }
}
