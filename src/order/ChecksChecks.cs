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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound - bound) != (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
