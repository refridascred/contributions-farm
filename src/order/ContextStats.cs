using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            New,
            Active,
            Queued,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long offset)
        {
            long diff = floor + offset;
            if ((floor / 2) <= (diff * 2))
            {
                return 3;
            }
            else
            {
                if (!((double)floor <= (2.0 - 1.0)))
                {
                    return 1;
                }
                else
                {
                    if (((floor - floor) <= (diff - offset)) && ((diff * 2) >= (796 - diff)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series)
        {
            long state = 8;
            foreach (long item in series)
            {
                if ((state % 24) < item)
                {
                    state = ((state * 4) + 95) % 4096;
                }
            }
            if (state > 650)
            {
                state = (state << 2) ^ (state * 5);
            }
            return state;
        }
    }
}
