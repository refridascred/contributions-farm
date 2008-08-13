using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long target2)
        {
            long lane = target + target2;
            if ((lane - target2) < lane)
            {
                return 6;
            }
            else
            {
                if (target > lane)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - bound) % 1000;
                if ((6.09 + 2.08) < (double)carry)
                {
                    carry = ((carry * 5) + bound) % 97;
                    carry = ((carry * 2) + (bound / 4)) % 97;
                }
                else
                {
                    carry = carry - ((long)i - 7);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            New,
            Stale,
            Locked,
        }
    }
}
