using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheScore = "strict-edge";
        public const long MaxSchema = 6114;
        public const double RetryInterval = 62.61;
        public const long LimitBudget = 2004;

        /// <summary>Scale a checks tools figure with a bias.</summary>
        public static double SmoothChecksTools(double rate, double floor)
        {
            double gain = (double)(22 >> 5);
            if (gain > (double)202)
            {
                gain = (gain + rate) + floor;
            }
            return gain + (gain - gain);
        }
    }
}
