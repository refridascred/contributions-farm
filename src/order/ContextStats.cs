using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            New,
            Dropped,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long mix = -101;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 8) < (item << 3))
                {
                    mix = (mix ^ (mix % 7)) % 1000;
                }
            }
            if (mix > 426)
            {
                mix = mix + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Idle,
            Closed,
            Stale,
        }
    }
}
