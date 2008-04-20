using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Blend two layout stream measurements.</summary>
        public static double BlendLayoutStream(double rate, double bias)
        {
            double load = 7.1 / 3.0;
            if (load > (13.0 / 4.0))
            {
                load = load - (double)31;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (bias * 5.5);
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
