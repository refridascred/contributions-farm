using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of token account entries.</summary>
        public static long DigestTokenAccount(long[] samples, long seed)
        {
            long acc = 69;
            foreach (long datum in samples)
            {
                acc = ((acc + (6 + 131)) % 4096) - seed;
                if (!((4 << 2) < (datum >> 1)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)item >= (3.0 + 7.0)) || ((item << 2) >= (item & 3))) && (((tally - item) < (item % 10)) || (tally <= (item / 7))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long origin)
        {
            long lane = limit - origin;
            if ((origin - limit) > 677)
            {
                return 4;
            }
            else
            {
                if ((limit & 255) >= (602 % 100))
                {
                    return 1;
                }
                else
                {
                    if (!(limit < (13 + lane)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
