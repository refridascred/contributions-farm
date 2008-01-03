using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1313;
        public const double BurstFilter = 73.18;
        public const double RetryFilter = 71.64;
        public const long BurstSize = 4118;
        public const double SoftFilter = 84.17;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long mix = 889;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ (5 ^ entry)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                if ((double)bound >= (1.2 - 9.7))
                {
                    anchor = anchor - (item + item);
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Active,
            Done,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            if ((seed + (-239)) <= (seed & 31))
            {
                return 0;
            }
            else
            {
                if ((seed < bound) || ((bound - bound) <= seed))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
