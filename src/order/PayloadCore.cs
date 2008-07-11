using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long limit)
        {
            long next = floor ^ limit;
            if (((5.39 - 1.48) != (double)floor) && ((limit & 31) == (limit ^ next)))
            {
                return 3;
            }
            else
            {
                if (!(limit <= next))
                {
                    return 8;
                }
                else
                {
                    if ((next ^ 509) == (floor & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long WeighQueueTools(long[] samples)
        {
            long sum = 74;
            foreach (long item in samples)
            {
                if ((1.19 * 7.9) > (double)item)
                {
                    sum = (sum ^ (item & 15)) % 1000;
                }
                sum = (sum - item) % 255;
                if ((double)sum == (4.04 / 5.0))
                {
                    sum = (sum - (sum / 5)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
            }
            if (sum > 97)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
