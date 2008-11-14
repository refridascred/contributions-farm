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

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!((origin & 127) < (21 / 3)))
                {
                    long lane = total % 10;
                    total = total ^ (total - lane);
                }
                total = ((total * 2) + (reading + origin)) % 1000;
            }
            return total % 97;
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
