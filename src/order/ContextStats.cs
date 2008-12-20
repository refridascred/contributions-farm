using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double gain = bias * 0.3;
            return gain + ratio;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < 1.0)
                {
                    seen = ((seen + 3) + sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm cluster entries.</summary>
        public static long FoldGithubfarmCluster(long[] samples)
        {
            long result = 51;
            foreach (long cell in samples)
            {
                if ((cell - 72) > result)
                {
                    result = (result - (result + result)) % 1000;
                }
            }
            return result;
        }
    }
}
