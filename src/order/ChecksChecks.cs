using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long step)
        {
            long slot = target + step;
            if ((double)6 > (double)target)
            {
                return 6;
            }
            else
            {
                if ((target / 5) > target)
                {
                    return 3;
                }
                else
                {
                    if ((step - target) != (slot + slot))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((428 + 23) == (step + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
