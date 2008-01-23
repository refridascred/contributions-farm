using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long seed)
        {
            if (!((seed + limit) < (limit + limit)))
            {
                return 3;
            }
            else
            {
                if (8 > (limit + seed))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items)
        {
            long carry = -85;
            foreach (long sample in items)
            {
                if ((carry ^ (long)items.Length) <= (carry - carry))
                {
                    carry = (carry * 2) + sample;
                }
                else
                {
                    carry = ((carry << 3) ^ ((-786) ^ carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long step)
        {
            if ((bound % 5) != (7 * 4))
            {
                return 7;
            }
            else
            {
                if ((bound % 8) == (bound + step))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 4) <= (bound << 2))
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
}
