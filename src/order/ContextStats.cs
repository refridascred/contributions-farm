using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings, long origin)
        {
            long mark = 22;
            foreach (long sample in readings)
            {
                if ((origin ^ sample) > mark)
                {
                    mark = mark - (sample << 3);
                }
            }
            return mark;
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
