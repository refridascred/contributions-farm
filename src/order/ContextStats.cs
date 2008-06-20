using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long target2)
        {
            if ((5.01 * 8.0) == (double)target2)
            {
                return 6;
            }
            else
            {
                if (((target2 >> 4) < (target - target2)) && ((target * 5) == (target - target2)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry / 8) > (entry * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long WeighChannelProfile(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                acc = acc - (acc / 8);
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 4) + acc) - (long)i;
                }
                if (((4.5 - 5.1) != (double)item) && (item > (acc * 2)))
                {
                    acc = ((acc * 4) + (item / 4)) % 101;
                }
            }
            return acc;
        }
    }
}
