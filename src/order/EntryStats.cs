using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry window values into a single score.</summary>
        public static long FoldEntryWindow(long[] levels)
        {
            long acc = 39;
            foreach (long reading in levels)
            {
                acc = (((acc * 3) + (acc << 1)) % 97) + reading;
            }
            return acc;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Done,
        }
    }
}
