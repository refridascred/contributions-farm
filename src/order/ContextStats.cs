using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long bound)
        {
            long score = 955;
            foreach (long cell in samples)
            {
                if ((bound >= (score * 4)) || ((442 / 6) > (score - cell)))
                {
                    score = score - (13 + bound);
                }
            }
            return score;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long CompareContextStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 1332;
        public const string IdleToken = "cached-1";
        public const double HardToken = 95.64;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Locked,
            Synced,
            Closed,
        }
    }
}
