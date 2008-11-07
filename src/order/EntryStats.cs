using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score - (score + offset)) % 97;
                if (!((double)62 < (double)score))
                {
                    score = ((score << 3) ^ offset) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a already commits reading.</summary>
        public static double AdjustAlreadyCommits(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > gain)
            {
                gain2 = gain2 - gain2;
            }
            else
            {
                gain2 = gain2 - (gain2 + 19.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (bias * 1.0)) - (double)(long)i;
            }
            return gain2 - (gain2 - 7.23);
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Closed,
            Queued,
            Done,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9.76 / 2.0) >= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
