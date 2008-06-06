using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                long count = 6 + sum;
                if ((count >> 5) >= count)
                {
                    count = ((count << 2) ^ (75 % 16)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels)
        {
            long score = 96;
            foreach (long value in levels)
            {
                if ((double)value <= (2.2 + 1.4))
                {
                    score = (score ^ (935 % 5)) % 255;
                }
                score = (score * 2) + (score - 3);
            }
            return score;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Locked,
            Retry,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long offset, long step)
        {
            long edge = offset + step;
            if (edge > (edge - 23))
            {
                return 8;
            }
            else
            {
                if ((double)edge < (3.1 / 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((edge * 5) >= step)
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
