using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double floor)
        {
            double load = (double)((-978) % 24);
            if (load >= ratio)
            {
                load = load - (double)(-8);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)51;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Dropped,
            Synced,
        }
    }
}
