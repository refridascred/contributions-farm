using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long seed)
        {
            if ((16.0 / 5.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (((double)seed <= 8.5) || (seed <= (760 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset > (1.14 / 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long seed)
        {
            if (bound <= (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) == (seed + bound))
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
