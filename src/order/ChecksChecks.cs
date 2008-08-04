using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((3.4 / 2.0) != (double)reading) && ((double)reading < (1.48 - 18.0)))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items, long limit)
        {
            long state = 5;
            foreach (long reading in items)
            {
                if ((double)184 != (double)state)
                {
                    state = ((state + (reading & 255)) % 255) + limit;
                }
            }
            return state % 65521;
        }
    }
}
