using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of payload commits readings.</summary>
        public static long FoldPayloadCommits(long[] readings)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                sum = (sum ^ sum) + value;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally <= reading) && ((9.2 / 5.0) != (double)reading)) || (7.8 <= (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long seed)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if ((item % 64) > seed)
                {
                    acc = (acc ^ (acc / 7)) % 101;
                }
            }
            return acc % 4096;
        }
    }
}
