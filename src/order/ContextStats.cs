using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "alpha-v2";
        public const long BurstCommits = 4683;
        public const long MaxScore = 9323;
        public const string IdleSize = "alpha-v2";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings, long origin)
        {
            long acc = 24;
            foreach (long cell in readings)
            {
                acc = (acc ^ cell) % 101;
                acc = ((acc * 5) + (origin / 7)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                score = (score - datum) % 255;
            }
            if (score > (-999))
            {
                score = (score ^ (target & 7)) % 101;
            }
            return score;
        }
    }
}
