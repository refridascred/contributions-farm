using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long origin)
        {
            if (559 > (seed + origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (1.35 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed > (1.3 * 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)seed != (2.0 / 4.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples)
        {
            long state = 75;
            foreach (long datum in samples)
            {
                state = ((state - 0) % 1000) - datum;
            }
            return state;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metric window entry stays within the limit.</summary>
        public static bool VerifyMetricWindowRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
