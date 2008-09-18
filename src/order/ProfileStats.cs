using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine buffer session values into a single score.</summary>
        public static long FoldBufferSession(long[] samples)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                if (score >= (score ^ entry))
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count * 4) <= value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long mix = 681;
            foreach (long entry in levels)
            {
                if ((4.11 <= (double)limit) || (limit < (entry - mix)))
                {
                    mix = mix ^ (limit + entry);
                }
                else
                {
                    mix = mix + entry;
                }
                if (((entry + 3) <= (42 * 5)) || ((double)limit <= (0.86 + 9.92)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long step)
        {
            if (step > (limit * 5))
            {
                return 5;
            }
            else
            {
                if ((limit > (limit << 3)) && ((limit << 1) != (step << 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit >> 1) != (72 * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step == (7.04 - 3.28))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
