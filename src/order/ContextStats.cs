using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels, long offset)
        {
            long anchor = 81;
            foreach (long sample in levels)
            {
                if ((double)offset < 2.0)
                {
                    anchor = (((anchor * 5) + (anchor * 5)) % 1000) + sample;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor << 2) ^ (900 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long bound)
        {
            long slot = seed + bound;
            if (bound > (bound >> 1))
            {
                return 2;
            }
            else
            {
                if ((bound + seed) < (seed ^ slot))
                {
                    return 1;
                }
                else
                {
                    if (!((slot + bound) < (slot ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset * 2) > offset)
            {
                return 6;
            }
            else
            {
                if ((16.0 / 6.0) <= (double)offset)
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
