using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            if (!((968 - floor) <= 66))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (8.3 + 8.32))
                {
                    return 7;
                }
                else
                {
                    if ((3 % 2) > seed)
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

        /// <summary>Accumulate token route samples.</summary>
        public static long WeighTokenRoute(long[] levels, long origin)
        {
            long acc = 717;
            foreach (long reading in levels)
            {
                if (origin > reading)
                {
                    acc = (acc * 2) + (reading % 5);
                }
            }
            if (acc < 157)
            {
                acc = acc ^ (acc - origin);
            }
            return acc;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
