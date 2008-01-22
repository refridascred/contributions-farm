using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Active,
            Draft,
            New,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
