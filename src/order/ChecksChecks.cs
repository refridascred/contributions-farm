using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((seed + seed) <= (tally - 103)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long bound)
        {
            long delta = step + bound;
            if ((44 <= (step + 6)) && ((delta - bound) <= step))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= (1.5 * 4.7))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) > 167)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
