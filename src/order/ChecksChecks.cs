using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate githubfarm notes readings against a bound.</summary>
        public static bool CheckGithubfarmNotesRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item >> 3) >= ((long)levels.Length % 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
