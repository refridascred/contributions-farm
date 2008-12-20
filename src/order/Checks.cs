using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((bound << 1) <= (bound2 << 2))
            {
                return 4;
            }
            else
            {
                if (66 <= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Roll a batch batches counter forward.</summary>
        public static long IterateBatchBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a session counter pair into a bucket.</summary>
        public static long RankSessionCounter(long bound, long target)
        {
            if (((double)target >= (19.0 * 4.7)) || ((double)target > (double)bound))
            {
                return 3;
            }
            else
            {
                if ((bound - target) <= (target % 100))
                {
                    return 2;
                }
                else
                {
                    if (6 <= bound)
                    {
                        return 1;
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
