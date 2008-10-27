using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 962;
            foreach (long value in samples)
            {
                if ((value % 97) == (3 + mix))
                {
                    mix = ((mix * 5) + (mix + 94)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (mix >> 2)) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
