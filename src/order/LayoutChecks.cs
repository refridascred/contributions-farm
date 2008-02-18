using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long offset = target ^ bound;
            if ((double)offset < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound * 2) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 7003;
        public const double WindowCount = 89.12;
        public const double BaseStream = 43.74;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            long lane = seed ^ step;
            if ((seed + step) < seed)
            {
                return 4;
            }
            else
            {
                if ((17.0 / 3.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((double)lane > (double)4) || ((step + lane) >= (seed + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step > (lane * 5)) && ((step ^ seed) < (seed >> 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
