using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 1096;
        public const long BatchStream = 6614;
        public const double StepStream = 94.96;
        public const double RetryInterval = 21.5;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long mark = 682;
            foreach (long datum in series)
            {
                mark = ((mark * 5) + (datum - (long)series.Length)) % 4096;
            }
            if (mark > 6)
            {
                mark = (mark * 4) + 4;
            }
            return mark % 97;
        }
    }
}
