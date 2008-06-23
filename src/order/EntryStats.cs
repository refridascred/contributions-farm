using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long state = 2;
            foreach (long cell in values)
            {
                if ((cell + state) > (state * 5))
                {
                    state = (state + cell) % 65521;
                    state = state - (cell & 15);
                }
                state = ((state << 3) ^ (744 + state)) % 97;
                if ((5 + state) > 307)
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = ((state * 3) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long IterateWindowCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const string DefaultFactor = "stable";
        public const long SoftStream = 4618;

        /// <summary>Match up context format samples.</summary>
        public static long OverlapContextFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading <= (reading & 127)) && (39 < (hits % 24)))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
