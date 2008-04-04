using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Draft,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long CombineStreamToken(long[] samples)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                if (score <= entry)
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score << 2) ^ (67 + score);
                }
            }
            return score;
        }

        /// <summary>Measure how many githubfarm metrics samples are out of range.</summary>
        public static long TallyGithubfarmMetricsHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally <= (double)bound)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
