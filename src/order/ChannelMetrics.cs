using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (2.3 < (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double bias = offset * 4.74;
            if (bias < (double)46)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + (weight - 0.25);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 9.0)) - (double)(long)i;
            }
            return bias + (double)1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
