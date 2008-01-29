using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long bound)
        {
            if ((8.1 / 6.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((step & 1) >= (bound % 100))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound >= (0.2 - 6.35))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound != (double)step) || ((58 + step) >= (step + bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Synced,
            Retry,
        }
    }
}
