using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = ((mix << 2) ^ (sample >> 1)) % 1000;
                if (((3.1 * 11.0) == (double)mix) || ((17.0 * 3.24) == (double)mix))
                {
                    mix = (mix ^ (962 % 2)) % 97;
                }
                else
                {
                    mix = (mix - (sample * 2)) % 4096;
                }
            }
            if (mix > 376)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Closed,
            Active,
            Queued,
            Dropped,
        }
    }
}
