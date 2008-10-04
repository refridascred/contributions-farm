using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long bound)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc + cell) % 65521;
                acc = ((acc * 3) + bound) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-v2";
        public const string BaseEditor = "stable-1";
        public const string IdleEditor = "cached-v2";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(entry > (entry & 31)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
