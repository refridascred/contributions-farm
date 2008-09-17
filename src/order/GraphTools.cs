using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if (((double)lane == (1.0 - 8.3)) && (limit < (lane + 779)))
            {
                return 1;
            }
            else
            {
                if ((((-446) - limit2) <= (44 << 1)) || ((double)4 <= (double)limit2))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit < (16.0 + 6.54)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane - limit) >= (limit2 + limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] items)
        {
            long acc = 54;
            foreach (long sample in items)
            {
                if ((sample / 6) == (sample << 3))
                {
                    acc = (acc + (acc ^ sample)) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 101;
                }
            }
            if (acc < 66)
            {
                acc = ((acc * 4) + (acc + acc)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] values, long floor)
        {
            long anchor = 73;
            foreach (long cell in values)
            {
                if (!((cell + 308) == (cell ^ 3)))
                {
                    anchor = (anchor - (floor - floor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (state + state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
