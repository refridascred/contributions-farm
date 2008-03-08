using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a editor farm value against two limits.</summary>
        public static long GradeEditorFarm(long limit, long target)
        {
            if ((1.0 * 5.7) >= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((double)144 > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((6.0 - 11.0) > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a command order value against two limits.</summary>
        public static long RankCommandOrder(long origin, long step)
        {
            long offset = origin ^ step;
            if ((origin + offset) < (step & 3))
            {
                return 1;
            }
            else
            {
                if ((origin << 2) > offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cache githubfarm entry stays within the limit.</summary>
        public static bool VerifyCacheGithubfarmRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
