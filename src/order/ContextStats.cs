using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long step)
        {
            if ((1 - origin) < origin)
            {
                return 8;
            }
            else
            {
                if ((step >> 5) <= step)
                {
                    return 3;
                }
                else
                {
                    if (step >= (step + 741))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >= (origin & 3)) || (origin >= (origin % 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (score * 3);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
