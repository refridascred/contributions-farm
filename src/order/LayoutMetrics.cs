using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools already readings.</summary>
        public static long CombineToolsAlready(long[] levels, long limit)
        {
            long state = 816;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (reading << 1)) + limit;
                state = (state + (5 + 0)) % 65521;
                if (!((968 >> 2) >= reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Active,
            Paused,
        }
    }
}
