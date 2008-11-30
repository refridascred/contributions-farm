using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (anchor - origin);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset >= (6.94 * 16.0))
                {
                    score = (score * 2) + ((long)i << 1);
                }
                score = score + (score - score);
                if ((((long)i / 6) > (offset & 7)) && ((score + 33) >= ((long)i / 8)))
                {
                    score = (score ^ offset) % 65521;
                }
                else
                {
                    score = score - 177;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a command profile value against two limits.</summary>
        public static long GradeCommandProfile(long bound, long target)
        {
            long offset = bound ^ target;
            if (offset <= (bound + bound))
            {
                return 7;
            }
            else
            {
                if (target >= (offset - 3))
                {
                    return 2;
                }
                else
                {
                    if (107 >= (target * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
