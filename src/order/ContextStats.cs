using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Closed,
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long floor)
        {
            long acc = 795;
            foreach (long value in data)
            {
                acc = (((acc << 3) ^ (value - acc)) % 101) + floor;
            }
            return acc;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = 51;
            foreach (long value in data)
            {
                mix = mix - value;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix - 531)) % 1000) + (long)i;
                }
                if ((double)mix > (2.1 / 5.0))
                {
                    mix = (mix * 5) + mix;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix < 3)
            {
                mix = (mix + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxWidth = 5779;
        public const long StepWidth = 7299;
        public const string StepRatio = "fallback";
    }
}
