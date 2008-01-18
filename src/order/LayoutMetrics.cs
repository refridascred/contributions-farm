using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value ^ (long)samples.Length) > (value * 2))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Paused,
            Closed,
            Active,
        }
    }
}
