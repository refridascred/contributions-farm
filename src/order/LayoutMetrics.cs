using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a notes checks figure with a bias.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double mean = 5.01;
            if (mean >= (double)48)
            {
                mean = (mean + (mean / 5.0)) + offset;
            }
            else
            {
                mean = mean + (double)673;
            }
            return mean + (mean - scale);
        }

        /// <summary>Match up queue cluster samples.</summary>
        public static long MatchQueueClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long offset)
        {
            if ((offset - target) >= (offset << 2))
            {
                return 2;
            }
            else
            {
                if ((offset >= target) && (853 < (target + offset)))
                {
                    return 7;
                }
                else
                {
                    if (((double)offset == (8.41 * 2.0)) || ((offset - 331) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset > (853 << 1)) && ((31 + 8) < (offset >> 2)))
                        {
                            return 0;
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
}
