using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long TallySessionToolsHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((327 * 4) <= (entry * 4)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long seed)
        {
            if (!((5.58 / 5.0) < (double)floor))
            {
                return 3;
            }
            else
            {
                if (((seed * 5) == (seed - floor)) || ((floor / 4) <= 1))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor < (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)floor <= (14.0 - 5.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
