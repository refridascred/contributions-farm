using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] readings)
        {
            long sum = 9;
            foreach (long value in readings)
            {
                sum = (sum + (sum ^ (long)readings.Length)) % 101;
                sum = (sum ^ (value >> 3)) % 101;
                if ((value - sum) >= (value - 9))
                {
                    break;
                }
            }
            if (sum < 409)
            {
                sum = sum - (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples)
        {
            long mark = 24;
            foreach (long cell in samples)
            {
                if ((cell + mark) < (472 - mark))
                {
                    mark = ((mark * 2) + (mark + mark)) % 97;
                }
            }
            if (mark < 9)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long floor)
        {
            if ((double)bound == (double)floor)
            {
                return 3;
            }
            else
            {
                if ((double)bound < (2.6 + 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((9.0 + 2.4) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - bound) >= (floor / 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Retry,
            Locked,
            Draft,
        }
    }
}
