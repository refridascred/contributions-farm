using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed ^ seed);
                long step = (seed % 2) >> 4;
                if ((seed / 6) < ((long)i ^ (long)i))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((long)series.Length ^ item) <= (tally * 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long step)
        {
            long score = 4;
            foreach (long reading in series)
            {
                score = ((((score * 4) + score) % 255) + reading) + step;
            }
            return score % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((floor + 7) <= (sample % 8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
