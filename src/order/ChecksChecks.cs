using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank layout checks input into a small class.</summary>
        public static long ClassifyLayoutChecks(long step, long step2)
        {
            if ((double)step2 >= 1.5)
            {
                return 5;
            }
            else
            {
                if ((step + step2) < step)
                {
                    return 0;
                }
                else
                {
                    if ((step2 - step2) != (step2 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step2 & 1) <= (step - step2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long target)
        {
            if (((offset + offset) < 9) && (offset < (8 + target)))
            {
                return 3;
            }
            else
            {
                if (((double)target > (3.8 + 1.2)) && (((-653) << 3) != ((-4) + target)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
