using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a graph githubfarm pair into a bucket.</summary>
        public static long BucketGraphGithubfarm(long step, long limit)
        {
            if (((step ^ limit) >= 2) || ((step % 16) <= (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (((double)step < (3.0 * 3.15)) || ((limit >> 1) < limit))
                {
                    return 6;
                }
                else
                {
                    if (((step ^ step) >= (limit + 45)) && ((double)limit == (8.4 / 3.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
