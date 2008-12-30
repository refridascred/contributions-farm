using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long step)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                if (((cell + cell) >= (anchor - anchor)) || ((20.0 + 5.0) <= (double)anchor))
                {
                    anchor = anchor ^ (step ^ cell);
                }
            }
            if (anchor > 761)
            {
                anchor = (anchor << 2) ^ step;
            }
            return anchor % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values)
        {
            long carry = 83;
            foreach (long value in values)
            {
                carry = carry - value;
            }
            if (carry > 894)
            {
                carry = (carry - (carry * 2)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long floor)
        {
            long result = -261;
            foreach (long datum in items)
            {
                if (((double)result == (double)floor) || ((double)datum > (8.53 * 9.0)))
                {
                    result = (result << 3) ^ (result + floor);
                }
            }
            if (result < (-87))
            {
                result = result ^ result;
            }
            return result;
        }
    }
}
