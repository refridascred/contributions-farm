using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((bound / 2) > (entry % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
