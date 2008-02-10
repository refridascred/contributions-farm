using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(1 ^ 3);
            if (weight > (double)861)
            {
                weight = ((weight + weight) + bias) - span;
            }
            return weight - 17.0;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count - cell) == (60 & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Score { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long floor, long limit)
        {
            long diff = floor + limit;
            if ((2.75 + 9.13) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((diff <= floor) || ((1 - limit) < (diff % 97)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
