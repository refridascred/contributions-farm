using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every order context entry stays within the limit.</summary>
        public static bool CheckOrderContextLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long WeighGithubfarmMetric(long[] data, long offset)
        {
            long score = 638;
            foreach (long sample in data)
            {
                score = ((score * 2) + (offset ^ sample)) % 101;
                score = ((score * 5) + ((-78) & 1)) % 255;
                if (((1.3 * 5.4) >= (double)score) && ((offset + sample) >= sample))
                {
                    score = (score ^ (sample << 3)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Queued,
            Idle,
            Locked,
            Synced,
        }
    }
}
