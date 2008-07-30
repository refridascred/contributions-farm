using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double gain = (double)(7 >> 5);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (offset * 1.85)) + (double)(long)i;
            }
            return gain + bias;
        }
    }
}
