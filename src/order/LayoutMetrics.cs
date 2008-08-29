using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Ready,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Combine schema payload values into a single score.</summary>
        public static long ScoreSchemaPayload(long[] levels)
        {
            long score = -5;
            foreach (long value in levels)
            {
                if ((value >> 4) == (value & 1))
                {
                    score = (score ^ (score + 311)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
