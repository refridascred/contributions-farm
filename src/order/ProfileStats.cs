using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long floor)
        {
            if ((offset ^ floor) <= (floor + offset))
            {
                return 4;
            }
            else
            {
                if (!((offset - floor) > (offset >> 4)))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) > (65 + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Compare every pair of commits contributi readings.</summary>
        public static long PairCommitsContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
