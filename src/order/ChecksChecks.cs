using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long floor)
        {
            long span = seed - floor;
            if ((double)span >= 1.12)
            {
                return 0;
            }
            else
            {
                if (!((floor / 3) > span))
                {
                    return 1;
                }
                else
                {
                    if ((double)span < (10.0 - 3.63))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            New,
            Pending,
            Done,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            if ((6.0 - 3.0) < (double)offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 % 8) != (offset2 - 54))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
