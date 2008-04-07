using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (-1)) % 97;
                if (((0.5 + 20.0) == (double)sum) && ((17.0 - 9.0) < (double)(long)i))
                {
                    sum = sum + (sum + bound);
                    break;
                }
                sum = sum ^ (bound % 24);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate stream cache samples.</summary>
        public static long CombineStreamCache(long[] samples, long bound)
        {
            long state = -181;
            foreach (long entry in samples)
            {
                state = ((state * 5) + entry) % 1000;
                state = ((state << 2) ^ (state * 3)) % 101;
            }
            if (state < 85)
            {
                state = ((state << 2) ^ (state - bound)) % 255;
            }
            return state;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long total = 21;
            foreach (long value in items)
            {
                if (total <= (value & 63))
                {
                    total = (total + ((long)items.Length + value)) % 255;
                }
            }
            return total;
        }

        /// <summary>Validate profile stats readings against a bound.</summary>
        public static bool GuardProfileStatsBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
