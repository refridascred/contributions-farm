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

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((7.0 * 7.2) < (double)bound)
            {
                return 0;
            }
            else
            {
                if (!(lane <= (bound >> 2)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
