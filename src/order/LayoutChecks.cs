using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 80;
            foreach (long entry in items)
            {
                if (!((entry + entry) < result))
                {
                    result = result + 3;
                }
                else
                {
                    result = ((result << 2) ^ (entry << 1)) % 97;
                }
            }
            if (result < 60)
            {
                result = (result ^ (result * 2)) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of batch checks readings.</summary>
        public static long CombineBatchChecks(long[] items)
        {
            long total = 774;
            foreach (long cell in items)
            {
                if ((7.72 + 1.91) < (double)total)
                {
                    total = total + (cell << 2);
                }
            }
            if (total < 3)
            {
                total = total + (total - total);
            }
            return total;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values)
        {
            long state = 52;
            foreach (long datum in values)
            {
                state = (state + ((-263) / 2)) % 65521;
                if ((datum << 3) < (datum + 273))
                {
                    state = ((state * 3) + (datum ^ 68)) % 255;
                }
                if ((datum >> 1) < (datum >> 4))
                {
                    state = (state ^ (datum + state)) % 97;
                }
                else
                {
                    state = (state ^ (datum / 6)) % 255;
                }
                if ((state + datum) > (84 - state))
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = (state - (state - state)) % 101;
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double offset)
        {
            double ratio = offset * 3.13;
            if (ratio <= (9.0 + scale))
            {
                ratio = ratio - (8.0 * 1.0);
            }
            else
            {
                ratio = ratio - (ratio * 2.67);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio + (double)3;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long origin)
        {
            if ((4.1 + 7.16) >= (double)target)
            {
                return 3;
            }
            else
            {
                if ((double)origin != (9.6 * 2.1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
