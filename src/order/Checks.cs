using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits cache entries.</summary>
        public static long TotalCommitsCache(long[] samples)
        {
            long mix = 25;
            foreach (long cell in samples)
            {
                mix = (mix - mix) - cell;
                mix = ((mix * 4) + (mix % 10)) % 1000;
            }
            return mix;
        }
    }
}
