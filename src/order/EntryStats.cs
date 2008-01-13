using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((value / 7) == (602 & 63)) && ((count + count) != (limit * 5))) || !(1 >= (value / 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) == (seen - 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double AdjustQueueAccount(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 7.5)
            {
                rate = rate + (rate - rate);
            }
            return rate + (6.75 + offset);
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
