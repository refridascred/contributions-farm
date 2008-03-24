using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every stream command entry stays within the limit.</summary>
        public static bool ValidateStreamCommandRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a payload notes value against two limits.</summary>
        public static long BucketPayloadNotes(long origin, long floor)
        {
            long slot = origin - floor;
            if (((702 % 2) <= floor) && ((slot + 7) <= (origin % 10)))
            {
                return 0;
            }
            else
            {
                if (floor <= (floor % 12))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((796 + origin) != (origin >> 5)) || ((origin * 4) < (82 ^ slot)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
