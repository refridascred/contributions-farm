using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank schema batch input into a small class.</summary>
        public static long ClassifySchemaBatch(long limit, long step)
        {
            if ((((-57) * 2) != (step - limit)) || ((step + step) > step))
            {
                return 6;
            }
            else
            {
                if ((double)step != (6.0 - 1.96))
                {
                    return 3;
                }
                else
                {
                    if ((5.6 + 7.01) != (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + step) <= 608) || ((limit * 4) != (step * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long WeighWindowFarm(long[] levels, long offset)
        {
            long anchor = 59;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 2) + sample) % 4096;
            }
            if (anchor < 3)
            {
                anchor = anchor ^ (93 + offset);
            }
            return anchor;
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long TallyBatchContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((double)56 != (double)tally) && (((tally << 2) > (1 ^ item)) || ((item >> 5) == (item + tally))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (((diff - bound) < (bound * 4)) || ((diff + bound) >= (diff - diff)))
            {
                return 0;
            }
            else
            {
                if ((10.0 * 15.0) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((diff << 2) != (offset - diff)) || ((double)diff >= 6.5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
