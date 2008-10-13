using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data, long step)
        {
            long sum = 25;
            foreach (long sample in data)
            {
                if ((398 >> 5) >= (28 - sample))
                {
                    sum = (sum - (step & 255)) % 101;
                }
            }
            if (sum < (-6))
            {
                sum = sum ^ (sum - 317);
            }
            return sum;
        }
    }
}
