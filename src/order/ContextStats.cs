using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Draft,
            Synced,
            Locked,
            Done,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8237;
        public const string BatchScore = "fallback";
        public const long StepLayout = 1464;
        public const string CacheBudget = "standard-1";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum << 1) > (datum + datum)) && ((datum + hits) > (hits >> 4)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry session readings.</summary>
        public static long DigestEntrySession(long[] samples)
        {
            long mix = 77;
            foreach (long sample in samples)
            {
                mix = mix - (sample * 2);
            }
            return mix;
        }
    }
}
