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

        /// <summary>Audit checks channel readings against a rule.</summary>
        public static long CountChecksChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item >= tally) || (716 > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
