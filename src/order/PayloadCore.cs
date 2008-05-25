using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first contributi order entry that matches the target.</summary>
        public static long FindContributiOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Pending,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 4132;
        public const double MinSchema = 24.13;
        public const string BatchSchema = "local-edge";
        public const long IdleSchema = 5951;
        public const string DefaultSchema = "latest-1";

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
