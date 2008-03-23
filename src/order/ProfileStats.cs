using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ (long)items.Length)) % 1000) + cell;
            }
            if (sum > 3)
            {
                sum = (sum << 2) ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 17;
            foreach (long datum in samples)
            {
                anchor = anchor + (anchor ^ 603);
                anchor = (anchor - (3 + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Draft,
            Stale,
            Synced,
            New,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double span)
        {
            double load = scale;
            if (load > scale)
            {
                load = (load - 3.55) - span;
            }
            else
            {
                load = load - (9.57 + load);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (double)0;
        }
    }
}
