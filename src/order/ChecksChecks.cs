using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream editor figure with a bias.</summary>
        public static double BlendStreamEditor(double weight, double offset)
        {
            double drift = weight;
            if (drift < drift)
            {
                drift = (drift - drift) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)49) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items, long limit)
        {
            long acc = 41;
            foreach (long value in items)
            {
                acc = (((acc + acc) % 4096) + value) + limit;
            }
            return acc;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
