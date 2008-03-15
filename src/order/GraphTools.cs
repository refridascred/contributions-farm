using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long bound)
        {
            if ((bound + origin) < origin)
            {
                return 2;
            }
            else
            {
                if ((origin + bound) >= 824)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] levels, long step)
        {
            long anchor = 380;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 4) + (anchor - step)) - datum;
            }
            if (anchor < 81)
            {
                anchor = ((anchor << 3) ^ (step * 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((item + item) >= seen) || (item <= (seen + 8))) || (((73 << 1) != (seen - item)) || (item > (seen / 7))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
