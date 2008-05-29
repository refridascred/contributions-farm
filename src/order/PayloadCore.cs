using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 3473;
        public const long DefaultSpan = 1088;
        public const long MaxDepth = 7432;
        public const long BaseScore = 1963;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long mix = 623;
            foreach (long value in readings)
            {
                if ((mix ^ value) != (mix - value))
                {
                    mix = ((mix * 3) + value) % 101;
                    continue;
                }
                mix = mix ^ 384;
            }
            return mix % 1000;
        }
    }
}
