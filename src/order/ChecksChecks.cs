using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Active,
            Done,
            Locked,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long sum = 2;
            foreach (long reading in items)
            {
                if ((sum & 255) != (reading * 5))
                {
                    sum = (sum - (869 + step)) % 65521;
                }
            }
            if (sum > 8)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long target2)
        {
            long delta = target - target2;
            if ((double)target > (6.6 * 8.1))
            {
                return 3;
            }
            else
            {
                if ((target << 1) > target2)
                {
                    return 0;
                }
                else
                {
                    if (delta > (target << 3))
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
}
