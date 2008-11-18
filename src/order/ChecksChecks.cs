using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item == (double)4)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of payload token readings.</summary>
        public static long FoldPayloadToken(long[] readings)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum ^ ((long)i << 1)) % 255;
                }
                sum = sum - (sum * 5);
                if ((datum % 24) < (876 - sum))
                {
                    sum = sum - (7 / 2);
                }
            }
            return sum;
        }
    }
}
