using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels, long limit)
        {
            long mix = 0;
            foreach (long sample in levels)
            {
                mix = (mix - limit) % 255;
                mix = (mix + (sample & 127)) % 1000;
                mix = mix ^ (mix * 2);
            }
            return mix;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
