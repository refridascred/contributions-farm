using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a githubfarm batch reading.</summary>
        public static double ScaleGithubfarmBatch(double scale, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate - rate;
            }
            return rate + scale;
        }
    }
}
