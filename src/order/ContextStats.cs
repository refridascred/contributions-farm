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

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
