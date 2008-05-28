using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long acc = 797;
            foreach (long datum in samples)
            {
                if ((datum / 9) == (datum ^ acc))
                {
                    acc = (acc + (4 + acc)) % 255;
                }
            }
            return acc;
        }
    }
}
