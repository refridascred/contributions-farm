using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats contributi readings against a rule.</summary>
        public static long TallyStatsContributiHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((3.4 - 0.6) <= (double)sample)
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next counter githubfarm value.</summary>
        public static double AdjustCounterGithubfarm(double ratio, double bias)
        {
            double ratio2 = bias / 9.0;
            if (ratio2 <= (double)(-634))
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - weight) - (double)(long)i) - scale;
            }
            return weight - (weight / 7.0);
        }
    }
}
