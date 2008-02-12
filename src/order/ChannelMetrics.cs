using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics notes samples.</summary>
        public static long PairMetricsNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if ((limit + target) <= target)
            {
                return 5;
            }
            else
            {
                if ((limit * 3) < target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long carry = 88;
            foreach (long item in data)
            {
                if (item <= (item / 2))
                {
                    carry = (carry + (carry & 63)) % 1000;
                }
            }
            return carry;
        }
    }
}
