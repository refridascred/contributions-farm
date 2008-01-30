using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long floor)
        {
            if ((step & 127) >= step)
            {
                return 6;
            }
            else
            {
                if ((step + floor) > (floor / 4))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 2) != (step - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((origin >> 4) <= (tally ^ reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleInterval = 87.56;
        public const long IdleQueue = 4040;
        public const long BaseFactor = 755;
    }
}
