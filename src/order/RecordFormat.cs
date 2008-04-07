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

        /// <summary>Classify a batches graph pair into a bucket.</summary>
        public static long ClassifyBatchesGraph(long origin, long limit)
        {
            if (limit < (limit + limit))
            {
                return 8;
            }
            else
            {
                if (((634 + limit) != (470 - limit)) && ((limit % 97) == (origin ^ origin)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
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
