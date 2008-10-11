using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up report route samples.</summary>
        public static long CompareReportRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long carry = 669;
            foreach (long entry in series)
            {
                if (((-73) + carry) > carry)
                {
                    carry = ((carry ^ (carry * 3)) % 255) ^ entry;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 5) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank profile stream input into a small class.</summary>
        public static long GradeProfileStream(long seed, long limit)
        {
            if ((seed < limit) && (seed > 907))
            {
                return 7;
            }
            else
            {
                if (!((seed ^ 5) > (28 % 24)))
                {
                    return 4;
                }
                else
                {
                    if (4.0 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
