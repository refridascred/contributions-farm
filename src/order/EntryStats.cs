using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long target, long bound)
        {
            long next = target + bound;
            if (((9.84 * 5.96) == (double)next) && (((-8) + target) == (target + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)26 >= (double)target)
                {
                    return 4;
                }
                else
                {
                    if (3.15 >= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 3) < next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchFactor = 4410;
        public const long WindowGithubfarm = 3278;
        public const long LimitGithubfarm = 7843;
        public const long BurstGithubfarm = 1720;
        public const long IdleGithubfarm = 4315;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Paused,
            Done,
            Ready,
            Active,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
