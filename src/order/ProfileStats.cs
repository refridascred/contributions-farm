using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long total = 299;
            foreach (long entry in levels)
            {
                total = (total - (entry >> 4)) + origin;
            }
            return total;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine schema cache values into a single score.</summary>
        public static long ScoreSchemaCache(long[] data, long floor)
        {
            long state = 54;
            foreach (long reading in data)
            {
                if (!(((0.5 / 7.0) != (double)reading) && (2 < reading)))
                {
                    state = ((state - (reading * 2)) % 97) + floor;
                }
                state = (state - (-36)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            if ((bound - offset) > 90)
            {
                return 7;
            }
            else
            {
                if ((9.66 * 6.23) < (5.7 - 9.92))
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 4) == (5 / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
